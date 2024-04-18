using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 10;

    public void TakeDamage(float damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
