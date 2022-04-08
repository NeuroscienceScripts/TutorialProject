using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Variables : MonoBehaviour
{
    public static Variables Instance { get; private set; } // For setting Variables to be a Singleton

    public int MyPublicInteger = 5 ;
    [SerializeField]  private int myPrivateInteger = 3;

    public int GetMyPrivateInt()
    {
        return myPrivateInteger; 
    }

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

