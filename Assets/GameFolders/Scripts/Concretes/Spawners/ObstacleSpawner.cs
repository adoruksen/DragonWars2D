using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Controllers;
using DragonWars2D.PoolingSystem;

namespace DragonWars2D.Spawners
{
    public class ObstacleSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController pooledEnemy = ObstaclePool.instance.Get();
            pooledEnemy.transform.position = this.transform.position;
            pooledEnemy.gameObject.SetActive(true);
        }
    }
}

