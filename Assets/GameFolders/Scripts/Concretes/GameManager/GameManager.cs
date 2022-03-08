using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score;
    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //StartCoroutine(StartGame());
    }
    public void IncreaseScore()
    {
        score += 10;
        OnScoreChanged?.Invoke(score);
    }
    public void RestartGameFunc()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(RestartGame());
    }
    IEnumerator RestartGame()
    {
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
    IEnumerator StartGame()
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
}
