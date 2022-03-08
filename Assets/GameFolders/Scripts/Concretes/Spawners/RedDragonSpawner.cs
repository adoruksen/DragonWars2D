using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Controllers;
using DragonWars2D.PoolingSystem;


namespace DragonWars2D.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController enemy = RedDragonPool.instance.Get();
            enemy.transform.position = transform.position;
            enemy.gameObject.SetActive(true);
        }
    }
}

