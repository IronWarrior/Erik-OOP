using UnityEngine;

namespace TowerDefense
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        float speed = 5;

        [SerializeField]
        int totalHealth = 3;

        private int currentHealth;

        private void Awake()
        {
            currentHealth = totalHealth;
        }

        private void Update()
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        public Vector3 CenterOfMass()
        {
            return transform.position + Vector3.up;
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                // "Singleton" pattern.
                FindObjectOfType<Player>().AcquireResource();

                Destroy(gameObject);
            }
        }
    }
}
