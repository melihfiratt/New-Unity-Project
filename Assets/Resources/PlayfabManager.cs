using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayfabManager : MonoBehaviour
{
    public int coin;

    public TextMeshProUGUI tm;

    public Button buton;


    void Start()
    {
        
    }

    
    void update()
    {
        tm.text = coin.ToString();
    }
}
