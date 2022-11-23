using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnLocation;
    public Transform mainMenuCarLocation;
    LevelProperties lvp;


    public void spawnSomethingAwesomePlease(int location)
    {
        MarketSystem.Instance.SelectedCar.transform.position = spawnLocation[location].transform.position;
    }

    public void spawnCarTheirPlacePlease()
    {
        MarketSystem.Instance.SelectedCar.transform.position = mainMenuCarLocation.transform.position;
    }



}

