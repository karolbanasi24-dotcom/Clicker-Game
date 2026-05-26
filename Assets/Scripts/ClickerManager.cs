using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private ClickerUI clickerUI;
    [SerializeField] private Button Apple;
    private int score = 0;
    private int pointsPerClick = 1;

    private void Start()
    {
        clickerUI.UdateUI(score);
        Apple.onClick.AddListener(AddScore);
    }

    private void AddScore()
    {
        score += pointsPerClick;
        clickerUI.UdateUI(score);
    }
}
