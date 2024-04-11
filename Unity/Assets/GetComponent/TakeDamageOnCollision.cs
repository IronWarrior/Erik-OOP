using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{
    public int Health = 3;

    private void Start()
    {
        //      ourself!
        // Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamagingRigidbody damagingRigidbody 
            = collision.gameObject.GetComponent<DamagingRigidbody>();

        // Does the component exist on the object that hit us?
        if (damagingRigidbody != null)
        {
            Health -= damagingRigidbody.Damage;

            Debug.Log($"Took damage to {Health} health from {collision.gameObject.name}");
        }

        //if (collision.gameObject.name == "DamagingRigidbody")
        //{
        //    Health -= 1;

        //    Debug.Log($"Took damage to {Health} health from {collision.gameObject.name}");
        //}

        //if (collision.gameObject.name == "DangerousRigidbody")
        //{
        //    Health -= 2;

        //    Debug.Log($"Took damage to {Health} health from {collision.gameObject.name}");
        //}

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trigger!");
    }
}
