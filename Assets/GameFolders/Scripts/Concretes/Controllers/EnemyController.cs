using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.PoolingSystem;
using DragonWars2D.Abstracts.Controllers;


namespace DragonWars2D.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            currentTime = 0;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
      
    }
}

