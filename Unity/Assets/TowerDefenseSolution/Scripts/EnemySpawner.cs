using UnityEngine;

namespace TowerDefense
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField]
        Enemy enemyPrefab;

        [SerializeField]
        float spawnInterval = 1;

        private void Start()
        {
            InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);
        }

        private void Spawn()
        {
            Vector3 position = transform.position;
            position.x = Random.Range(-10, 10);

            Instantiate(enemyPrefab, position, transform.rotation);
        }
    }
}
