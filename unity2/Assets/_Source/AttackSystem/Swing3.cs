using Core;
using UnityEngine;

namespace AttackSystem
{
    public class Swing3 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack3");
        }
    }
}
