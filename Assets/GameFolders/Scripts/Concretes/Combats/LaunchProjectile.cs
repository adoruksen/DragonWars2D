using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Controllers;

namespace DragonWars2D.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] Transform projectilePos;
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile= 1f;

        float _currentDelayTime;
        bool canLaunch = false;
        private void Update()
        {
            _currentDelayTime += Time.deltaTime;
            if (_currentDelayTime > delayProjectile)
            {
                canLaunch = true;
                _currentDelayTime = 0;
            }
        }
        public void LaunchAction()
        {
            if (canLaunch)
            {
                ProjectileController newProjectile= Instantiate(projectilePrefab, projectilePos.position, projectilePos.rotation);
                newProjectile.transform.parent = projectileParent.transform;
                canLaunch = false;
            }
        }
    }
}

