using Core;
using UnityEngine;

namespace AttackSystem
{
    public class Swing2 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack2");
        }
    }
}
