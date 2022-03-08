using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Abstracts.PoolingSystem;
using DragonWars2D.Controllers;

namespace DragonWars2D.PoolingSystem
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
            {
                if (!child.gameObject.activeSelf) continue;
                child.KillGameObject();
            }
        }

        protected override void SingletonObject()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }


    }
}

