using TMPro;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _scoreText;
    private int _score;

    private void OnEnable()
    {
        EventBus.OnEnemyDied += AddScore;
        _score = 0;        
    }

    private void OnDisable()
    {
        EventBus.OnEnemyDied -= AddScore;
    }

    private void AddScore(int value)
    {
        _score += value;
        _scoreText.text = _score.ToString();
    }
}
