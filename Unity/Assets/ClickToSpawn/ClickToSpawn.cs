using UnityEngine;
using UnityEngine.InputSystem;

public class ClickToSpawn : MonoBehaviour
{
    public Camera cam;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Clicked!");
        }

        Vector2 mousePosition = Mouse.current.position.value;

        // Get the mouse position of the camera's "box",
        // and then get a "ray" that points out from the camera
        Ray ray = cam.ScreenPointToRay(mousePosition);

        //                                "out" means that this variable is empty when passed in,
        //                                 but will be filled by the function itself
        bool didHit = Physics.Raycast(ray, out RaycastHit hitInfo);

        if (didHit == true)
        {
            Debug.Log($"Object: {hitInfo.collider.name} position: {hitInfo.point}");
        }

        Color rayColor = didHit ? Color.red : Color.green;

        // a "ray" is just a position and a direction.
        Debug.DrawLine(ray.origin, ray.direction * 20f, rayColor);
    }
}
