using UnityEngine;

public class BikeSelector : MonoBehaviour
{
    public int bikeID; 

    public void SelectBike()
    {
        PlayerPrefs.SetInt("SelectedBike", bikeID);
        PlayerPrefs.Save();
        Debug.Log("Bike " + bikeID + " selected!");
    }
}