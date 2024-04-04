using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform target;

    public float speed = 2;

    // When is this function run?
    // Unity calls this every frame.
    // 10 frames per second - 1 / 10 = 0.1
    // 1000 frames per second - 1 / 1000 = 0.001
    private void Update()
    {
        Vector3 targetPosition = target.position;

        Vector3 directionToTarget = target.position - transform.position;

        Vector3 directionLengthOne = directionToTarget.normalized;

        //                                     ???????
        // GetComponent<Transform>().position += Vector3.right;

        //                                    1 / framerate
        transform.position -= directionLengthOne * speed * Time.deltaTime;

        // (0, 0, 0)
        // (0.000001f, 0.00001f, 0.00001f)

        float distance = Vector3.Distance(transform.position, targetPosition);

        // Destroy the game object when it arrives at the target.
        if (distance < 0.5f)
        {
            // A reference to the game object this script is attached to.
            Object.Destroy(gameObject);
        }
    }
}
