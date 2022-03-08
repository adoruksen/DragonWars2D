using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Combats;

namespace DragonWars2D.UI
{
    public class GameCanvas : MonoBehaviour
    {
        GameObject gameOverPanel;
        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleDead;
        }

        void HandleDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

