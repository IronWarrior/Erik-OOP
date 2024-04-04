using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform target;
    public float speed = 2;

    private void Update()
    {
        Vector3 directionToTarget = target.position - transform.position;

        transform.position += directionToTarget.normalized * speed * Time.deltaTime;
    }
}
