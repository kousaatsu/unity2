using Core;
using UnityEngine;

namespace AttackSystem
{
    public class Swing1 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack1");
        }
    }
}
