using UnityEngine;

namespace TowerDefense
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        float speed = 5;

        [SerializeField]
        int damage = 1;
        
        public Enemy target;

        private Vector3 lastTargetPosition;

        private void Update()
        {
            Vector3 targetPosition = target != null ? target.CenterOfMass() : lastTargetPosition;

            transform.position = Vector3.MoveTowards
                (transform.position,
                targetPosition, 
                speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                if (target != null)
                    target.TakeDamage(damage);

                Destroy(gameObject);
            }

            lastTargetPosition = targetPosition;
        }
    }
}