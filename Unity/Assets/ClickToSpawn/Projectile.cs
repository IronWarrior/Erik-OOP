using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform target;
    public float speed = 2;

    private void Update()
    {
        Vector3 directionToTarget = target.position - transform.position;

        transform.position += directionToTarget.normalized * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            target.GetComponent<Enemy>().TakeDamage(1);

            Destroy(gameObject);

            // "ourself" is dead at this point, right?
            // how does code continue to run?
            // In actuality, Unity has *scheduled* this object for destruction, but it still exists
            // until the end of the frame.

            //target.GetComponent<Enemy>().Health -= 1;

            //if (target.GetComponent<Enemy>().Health <= 0)
            //{
            //    Destroy(target.gameObject);
            //}
        }
    }
}
