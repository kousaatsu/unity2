using System.Collections;
using UnityEngine;

namespace EnemySystem
{

    public class Enemy1 : EnemyAnim
    {
        [SerializeField] private Animator _animator;
        private void OnEnable()
        {
            Attack();
        }

        public override void Attack()
        {
            _animator.SetTrigger("Attack1");
        }
    }
}
