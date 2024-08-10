// ScoreManager.cs
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreManager
{
    private int _score;
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        EventManager.OnMouseClick += () => IncreaseScore();
    }

    private void OnDisable()
    {
        EventManager.OnMouseClick -= () => IncreaseScore();
    }

    public void IncreaseScore()
    {
        _score++;
        scoreText.text = $"Score: {_score}";
    }
}