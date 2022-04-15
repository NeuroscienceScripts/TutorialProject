using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Variables : MonoBehaviour
{
    public static Variables Instance { get; private set; } // For setting Variables to be a Singleton

    // Set variables in a public field, makes running the experiment easier
    

    void Awake() // For making sure we only have one copy of Variables
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

