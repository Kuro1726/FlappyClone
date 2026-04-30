using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public static int score = 0;
    
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
}
