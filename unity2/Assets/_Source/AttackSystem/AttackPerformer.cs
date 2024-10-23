using Core;
using UnityEngine;
using System;

namespace AttackSystem
{
    public class AttackPerformer
    {
        private IAttackStrategy _attackStrategy;
        private Animator _animator;
        public static Action IsAttacking;

        public AttackPerformer(Animator animator)
        {
            _animator = animator;
        }

        public void SetStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void PerformAttack()
        {
            _attackStrategy.Attack(_animator);
            IsAttacking?.Invoke();
        }
    }
}
