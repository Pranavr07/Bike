using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value = 1; 
    private bool hasTriggered = false;

    private CoinManager coinManager;

    private void Start()
    {
        coinManager = CoinManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;

            coinManager.ChangeCoins(value);

            Destroy(gameObject);
        }
    }
}
