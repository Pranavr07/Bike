using UnityEngine;
using UnityEngine.UI;

public class VehicleSelector : MonoBehaviour
{
    public Button unlockButton;       // Assign your vehicle's button here
    public GameObject lockedIcon;     // Optional: a lock icon UI to show it's locked

    void Start()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0); // load saved coins

        if (coins >= 30)
        {
            unlockButton.interactable = true;
            if (lockedIcon != null)
                lockedIcon.SetActive(false);
        }
        else
        {
            unlockButton.interactable = false;
            if (lockedIcon != null)
                lockedIcon.SetActive(true);
        }
    }

    public void OnSelectVehicle()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0);
        if (coins >= 30)
        {
            Debug.Log("Vehicle Selected!");
            PlayerPrefs.SetInt("SelectedVehicle", 1); // Save selected vehicle
        }
        else
        {
            Debug.Log("Not enough coins to unlock!");
        }
    }
}
