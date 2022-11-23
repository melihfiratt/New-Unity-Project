using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffect : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundClip;
    private void Awake()
    {
        foreach (Button obje in Resources.FindObjectsOfTypeAll<Button>())
        {
            obje.onClick.AddListener(() => SoundEffects());
        }
    }
    public void SoundEffects()
    {
        sound.PlayOneShot(soundClip, 2);
    }
}
