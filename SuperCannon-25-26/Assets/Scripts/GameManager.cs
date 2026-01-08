using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] Text playerScoreText;
    [SerializeField] Text playerHealthText;

    public int StartHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameData.PlayerHealth = StartHealth;
        DisplayScore();
        DisplayHealth();
    }

    public void DisplayScore()
    {
       playerScoreText.text = "Score: " + GameData.Score.ToString();
    }

    public void DisplayHealth()
    {
       playerHealthText.text = "Health: " + GameData.PlayerHealth.ToString();
    }
}
