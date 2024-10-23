using System.Collections;
using UnityEngine;
using AttackSystem;

namespace EnemySystem
{

    public class Enemy3 : EnemyAnim
    {
        [SerializeField] private Animator _animator;
        private void OnEnable()
        {
            Attack();
        }
        public override void Attack()
        {
            AttackPerformer.IsAttacking += Animate;
        }
        void Animate()
        {
            _animator.SetTrigger("Attack3");
        }
    }
}
