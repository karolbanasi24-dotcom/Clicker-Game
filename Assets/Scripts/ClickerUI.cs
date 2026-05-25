using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Score_Counter;

    public void UdateUI(int amount)
    {
        Score_Counter.text = $"Score: {amount}";
    }
}
