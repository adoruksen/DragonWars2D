using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.PoolingSystem;

namespace DragonWars2D.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.instance.Set(this);
        }
    }
}

