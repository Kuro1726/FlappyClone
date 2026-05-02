using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public static int score = 0;
    
    public TextMeshProUGUI scoreText;

    public GameObject restartButtonObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
            
    }

    private void Start()
    {
        if (restartButtonObject != null)
        {
            restartButtonObject.SetActive(false);
        }
    }
    
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        score = 0;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowGameOver()
    {
        if (restartButtonObject != null)
        {
            restartButtonObject.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void ToggleMenu()
    {
        bool isShowing = restartButtonObject.activeSelf;
        Time.timeScale = isShowing ? 1f : 0f;
        restartButtonObject.SetActive(!isShowing);
    }
}
