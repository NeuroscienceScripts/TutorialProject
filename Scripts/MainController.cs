using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

/// <summary>
/// Typing triple / allows me to document my code.  This is useful (especially when working in groups)
/// because you can give a verbal definition of what each function is doing.  This docstring is available by
/// hovering over 'MainController' in any other file within the same namespace, or when MainController is the suggested
/// autofill. We can see an example of this by hovering over Unity's built-in Start(), Update(), and Awake() functions...
/// </summary>
public class MainController : MonoBehaviour
{
    // This line defines the logic of how an Instance of this MainController
    // will work. We can get the Instance or set the Instance of MainController.
    // This is necessary when creating a 'Singleton', something we only want to ever 
    // have a single instance of. 
    public static MainController Instance { get; private set; }
    public FileHandler fileHandler = new FileHandler(); // By making it public, I only need one FileHandler across files
    public int phase = 0;

    [SerializeField] private GameObject myUI;
    [SerializeField] private TextMeshProUGUI myText; 

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame, in general we want to set the flow of logic in Update at the beginning of coding. 
    // Separating the program into various phases allows for easily seeing what it is you're trying to accomplish.
    void Update()
    {
        /* I want this experiment to start with a Starting Screen where I enter in any relevant information,
            Task the participant with walking through 3 different objects and time how long it takes. 
            Ask the participant how hard it was on a scale of 1-10 */
        switch (phase)
        {
            case 0:
                RunStart(); 
                // Show UI, Wait for input
                // if ( GetInput) { phase ++ }
                break; 
            case 1:
                Debug.Log(myString); 
                // Wait for objects to be walked through
                // if ( allObjectsWalkedThrough == true) { phase ++; } 
                break; 
            case 2: 
                // Rate how hard it is 
                // if (currentTrial < numberTrials) { phase--; } 
                // else 
                // phase ++ 
                break; 
            case 3:
                // Display Finish Screen
                break; 
        }
        
    }

    private string myString; 
    private void RunStart()
    {
        // Show UI, Wait for input
        myUI.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            myUI.SetActive(false);
            myString = myText.text; 
            //subjectInfo = ; 
            phase++; 
        }
       

    }
    

    // Following code will check if there is already an active Instance of MainController. 
    // If there is, the gameObject this script is attached to will destroy itself. If there isn't,
    // the following code specifies to not destroy the current gameObject (so it can persist between scenes)
    void Awake()
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

