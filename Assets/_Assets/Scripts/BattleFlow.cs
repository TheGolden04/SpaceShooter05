using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI; 
    public GameObject gameWinUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;

    private void Start()
    {
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver; // Lắng nghe sự kiện khi người chơi chết.
    }
    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
        Debug.Log("LivingEnemyCount = " + EnemyHealth.LivingEnemyCount);
    }
    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
    private void OnGameWin()
    {
        Debug.Log("YOU WIN!");
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }
    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
