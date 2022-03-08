using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.PoolingSystem;

namespace DragonWars2D.Controllers
{
    public class ObstacleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObstaclePool.instance.Set(this);
        }
    }
}

