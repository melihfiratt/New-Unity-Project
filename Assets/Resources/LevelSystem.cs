using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{

    [SerializeField] private GameObject carCameraPrefab;

    [SerializeField] private Vector3 spawnPosition;


    public void play()
    {

        MarketSystem.Instance.mainMenuCamera.SetActive(true);
    

    }

    public void mainMenu()
    {
        MarketSystem.Instance.mainMenuCamera.SetActive(true);

    }
}
