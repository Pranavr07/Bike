using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    private int coins;

    [SerializeField] private TMP_Text coinsDisplay;

    private const string COIN_KEY = "TotalCoins";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            coins = PlayerPrefs.GetInt(COIN_KEY, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        coinsDisplay.text = coins.ToString();
    }

    public void ChangeCoins(int amount)
    {
        coins += amount;
        PlayerPrefs.SetInt(COIN_KEY, coins); 
    }

    public int GetCoins()
    {
        return coins;
    }

    public void ResetCoins()
    {
        coins = 0;
        PlayerPrefs.SetInt(COIN_KEY, coins);
    }
}
