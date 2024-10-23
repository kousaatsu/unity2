using UnityEngine;
using AttackSystem;
using EnemySystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener _inputListener;
        [SerializeField] private AttackStrategySetter _attackStrategySetter;
        [SerializeField] private Animator _animator;
        [SerializeField] private EnemyPool enemyPool;
        private EnemySetter _setter;
        private AttackPerformer _attackPerformer;

        private void Awake()
        {
            enemyPool.Construct();
            _setter = new EnemySetter(enemyPool);
            _attackPerformer = new AttackPerformer(_animator);
            _inputListener.Construct(_attackPerformer);
            _attackStrategySetter.Construct(_attackPerformer);
        }
    }
}
