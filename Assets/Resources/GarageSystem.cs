using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarageSystem : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentCarNumber = 0;
    public GameObject[] garage_cars;
    public MarketSystem ms;
    
    // Start is called before the first frame update


    private void Awake()
    {
        
        SelectCar(0);

    }
    
    private void SelectCar(int _index)
    {
        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != ms.purchased_cars.Count - 1);
        for (int i = 0; i < ms.purchased_cars.Count; i++)
        {
            ms.purchased_cars[i].gameObject.SetActive(i == _index);
        }
    }

    public void ChangeCar(int _change)
    {

        currentCarNumber += _change;
        SelectCar(currentCarNumber);

    }
}
