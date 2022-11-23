using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsMenu : MonoBehaviour
{
    private Text graphics;
    private Text language;
    [SerializeField] private GameObject sound;
    private Text other;

    public void upperFontSize()
    {
        sound.GetComponent<TMPro.TextMeshProUGUI>().fontSize = 50;
    }

}
