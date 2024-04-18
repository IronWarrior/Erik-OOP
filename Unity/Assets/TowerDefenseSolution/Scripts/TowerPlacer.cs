using UnityEngine;
using UnityEngine.InputSystem;

namespace TowerDefense
{
    public class TowerPlacer : MonoBehaviour
    {
        [SerializeField]
        Player player;

        [SerializeField]
        Tower towerPrefab;

        [SerializeField]
        Camera cam;

        private void Update()
        {
            if (Mouse.current.leftButton.wasPressedThisFrame && player.HasResources())
            {
                Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());

                if (Physics.Raycast(ray, out RaycastHit hitInfo))
                {
                    Instantiate(towerPrefab, hitInfo.point, Quaternion.identity);

                    player.SpendResource();
                }
            }
        }
    }
}