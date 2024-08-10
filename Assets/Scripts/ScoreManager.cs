using System;
using TMPro;
using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        EventManager.OnMouseClick += IncreaseScore;
        
    }

    private void OnDisable()
    {
        EventManager.OnMouseClick -= IncreaseScore;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score : "+score.ToString();
    }
}
