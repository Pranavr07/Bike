using UnityEngine;

public class BikeManager : MonoBehaviour
{
    public GameObject bike1;
    public GameObject bike2;

    void Start()
    {
        int selectedBike = PlayerPrefs.GetInt("SelectedBike", 1); 

        bike1.SetActive(selectedBike == 1);
        bike2.SetActive(selectedBike == 2);
    }
}