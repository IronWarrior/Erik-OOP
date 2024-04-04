using System.Collections.Generic;
using UnityEngine;

public class TowerFiring : MonoBehaviour
{
    public GameObject projectilePrefab;

    public List<GameObject> enemies;

    private void Start()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            // float distance = Vector3.Distance(transform.position, enemy.transform.position);

            Vector3 direction = transform.position - enemy.transform.position;

            float distance = direction.magnitude;

            if (distance < closestDistance)
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }

        if (closestEnemy != null)
        {
            GameObject spawnedProjectile = Instantiate(projectilePrefab, transform.position + Vector3.up, Quaternion.identity);

            spawnedProjectile.GetComponent<Projectile>().target = closestEnemy.transform;

            Debug.DrawLine(transform.position, closestEnemy.transform.position, Color.red, 1f);
        }

        // For every enemy...
        // Measure the distance from the tower to the enemy
        // Find which is closest
        // Perform the "fire" action at the enemy
    }
}
