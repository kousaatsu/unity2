using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyPool : MonoBehaviour
    {
        [SerializeField] private List<GameObject> enemies;

        private List<GameObject> _enemiesList;
        public void Construct()
        {
            InitPool();
        }

        private void InitPool()
        {
            _enemiesList = new List<GameObject>();
            for (int i = 0; i < enemies.Count; i++)
            {
                GameObject enemyInstance = Instantiate(enemies[i], transform);
                ReturnToPool(enemyInstance);
            }
        }

        public bool TryGetFromPool(out GameObject enemyInstance, Type enemyClass)
        {

            enemyInstance = null;
            if (_enemiesList.Count > 0)
            {

                foreach (var enemy in _enemiesList)
                {
                    enemy.TryGetComponent(out EnemyAnim enemyType);
                    if (enemyType != null && enemyType.GetType() == enemyClass)
                    {
                        enemy.SetActive(true);
                        enemyInstance = enemy;
                        _enemiesList.Remove(enemy);

                        return true;
                    }

                }

            }

            return false;
        }

        public void ReturnToPool(GameObject enemyInstance)
        {
            enemyInstance.SetActive(false);
            _enemiesList.Add(enemyInstance);
        }
    }
}

