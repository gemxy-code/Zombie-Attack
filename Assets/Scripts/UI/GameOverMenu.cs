using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private string _startPage = "MainMenu";

    public void Start()
    {
        /*
        int score = CountScore._score;
        int record = PlayerPrefs.GetInt("Record");

        if(score > record)
        {
            scoreText.text = "����� ������: " + score;
            PlayerPrefs.SetInt("Record", score);
        }
        else
        {
            scoreText.text = "������� �����: " + score;
        }
        */
    }

    public void ComeBackToMenu()
    {
        SceneManager.LoadScene(_startPage);
    }
}
