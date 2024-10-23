using System;
using UnityEngine;

namespace EnemySystem
{

    public class EnemySetter
    {
        private EnemyAnim _currentEnemy;
        private EnemyPool _enemyPool;
        private GameObject _activeEnemy;

        public EnemySetter(EnemyPool enemyPool)
        {
            _enemyPool = enemyPool;
            _activeEnemy = null;
        }
        public void ChangeActiveEnemy(Type newEnemy, GameObject spawnPoint)
        {

            if (_activeEnemy != null)
            {
                _enemyPool.ReturnToPool(_activeEnemy);
            }
            if (_enemyPool.TryGetFromPool(out GameObject enemyInstance, newEnemy))
            {
                enemyInstance.transform.position = spawnPoint.transform.position;
                _activeEnemy = enemyInstance;
            }
        }
    }
}
