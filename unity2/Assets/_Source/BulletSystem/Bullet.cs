using System.Collections;
using UnityEngine;

namespace BulletSystem
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D rb;

        private void Update()
        {
            Move();
        }

        void Move()
        {
            rb.AddForce(-transform.right * speed * Time.deltaTime, ForceMode2D.Impulse);
            StartCoroutine(DestroyTime());
        }
        private IEnumerator DestroyTime()
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
}
