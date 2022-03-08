using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonWars2D.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [SerializeField] float maxSpawnTime = 2.3f;
        [SerializeField] float minSpawnTime = .7f;

        float _currentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTimes();
        }

        void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }
        protected abstract void Spawn();

        void ResetTimes()
        {
            _currentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

