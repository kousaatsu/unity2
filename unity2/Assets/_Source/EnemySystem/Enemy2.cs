using System;
using System.Collections;
using UnityEngine;

namespace EnemySystem
{

    public class Enemy2 : EnemyAnim
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private GameObject _bulletPrefab;

        public override void Attack()
        {
            Instantiate(_bulletPrefab, transform);
        }
        private void OnEnable()
        {
            StartCoroutine(AttackCooldown());
        }

        private IEnumerator AttackCooldown()
        {
            yield return new WaitForSeconds(1);
            Attack();
        }
    }
}
