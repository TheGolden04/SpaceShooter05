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
    private void Awake()
    {
    // Reset giá trị ở biến static
        EnemyHealth.LivingEnemyCount = 0;
    }

    private void Start()
    {
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver; // Lắng nghe sự kiện khi người chơi chết.
    }
    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0) // Biến static EnemyHealth.LivingEnemyCount luôn tăng thêm 5 mỗi khi ta ấn play
        {
            OnGameWin();
        }
    }
    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }
    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }
    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
