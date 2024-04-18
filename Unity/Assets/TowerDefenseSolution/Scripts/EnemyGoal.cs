using UnityEngine;

namespace TowerDefense
{
    public class EnemyGoal : MonoBehaviour
    {
        [SerializeField]
        Player player;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Enemy>() != null)
            {
                Destroy(other.gameObject);

                player.TakeLife();
            }
        }
    }
}
