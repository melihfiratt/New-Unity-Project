using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineMachineController : MonoBehaviour
{

    Animator animator;
    private bool IsMainCamera = false;
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    
    void Update()
    {
        
    }

    public void CameraChange()
    {
        if (IsMainCamera)
        {
            animator.Play("MainMenuCamera");
        }
        else
        {
            animator.Play("GarageCamera");
        }
        IsMainCamera = !IsMainCamera;
    }
}
