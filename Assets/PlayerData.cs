using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int cash;
    public int money;

    public PlayerData(Player player)
    {
        cash = player.cash;
        money = player.money;
    }
 
}
