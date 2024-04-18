using UnityEngine;

namespace TowerDefense
{
    public class Tower : MonoBehaviour
    {
        [SerializeField]
        Projectile projectilePrefab;

        [SerializeField]
        float cooldown = 1f;

        [SerializeField]
        float range = 6f;

        private float lastFireTime;

        private void Update()
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();

            float nearestDistance = Mathf.Infinity;
            Enemy nearestEnemy = null;

            foreach (Enemy enemy in enemies)
            {
                float distance = Vector3.Distance(
                    transform.position, enemy.transform.position);

                if (distance < range && distance < nearestDistance)
                {
                    nearestEnemy = enemy;
                    nearestDistance = distance;
                }
            }

            if (nearestEnemy != null)
            {
                if (Time.time > lastFireTime + cooldown)
                {
                    Projectile spawned = Instantiate(
                        projectilePrefab, transform.position + Vector3.up * 1.5f, Quaternion.identity);

                    spawned.target = nearestEnemy;

                    lastFireTime = Time.time;
                }
            }
        }
    }
}
