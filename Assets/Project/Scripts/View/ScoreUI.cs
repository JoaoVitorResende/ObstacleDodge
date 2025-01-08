using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = Values.NeutralIntValue;

    private void Update()
    {
        UpdateScore();
    }
    private void UpdateScore()
    {
        if (score != GameManager.instance.GetScore())
        {
            scoreText.text = $"Hit Objects: {GameManager.instance.GetScore()}";
            score = GameManager.instance.GetScore();
        }
    }
}
