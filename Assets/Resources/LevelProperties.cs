using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProperties : MonoBehaviour
{
    [SerializeField] private int levelNumber = 0;

    public int getLevelNumber()
    {
        return this.levelNumber;
    }

}
