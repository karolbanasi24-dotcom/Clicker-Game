using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameMenager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    [SerializeField] private Button Apple;

    private void Start()
    {
        score = 0;
        UpdateScore();
        Apple.onClick.AddListener(AddScore);
    }
    public void AddScore()
    {
        score++;
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
