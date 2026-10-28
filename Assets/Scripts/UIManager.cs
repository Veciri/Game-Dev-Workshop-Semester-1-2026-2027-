using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int coins = 0;

    private void Start()
    {
        coinsText.text = "Coins: " + coins;
    }

    public void ModifyCoins(int modification)
    {
        coins += modification;
        coinsText.text = "Coins: " + coins;
    }
}
