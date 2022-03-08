using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DragonWars2D.UI
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }
        private void OnEnable()
        {
            GameManager.Instance.OnScoreChanged += HandleScoreEvent;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleScoreEvent;
        }
        private void HandleScoreEvent(int score=0)
        {
            _scoreText.text = $"Score:{score} " ;
        }

    }
}

