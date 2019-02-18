using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//THIS IS NEEDED TO USE THE SCENE LOADING COMMANDS

public class Respawn : MonoBehaviour
{

    //PUT THIS SCRIPT ON A SCENEMANAGER EMPTY GAME OBJECT

    public static string DEADCHECK;

    //YOU NEED TO SET THIS VARIABLE TO YES WHEN THE PLAYER DIES IN ANOTHER SCRIPT BY TYPING
    //Respawn.DEADCHECK = "Yes"
    //WHEN YOU DO THE SCENE WILL LOAD WHEN ANY BUTTON IS PRESSED

    //CALLED WHEN THE GAME STARTS
    void Start()
    {
        DEADCHECK = "No";
    }

    void sceneLoaded()
    //THIS IS CALLED WHEN THE SCENE LOADS
    {
        DEADCHECK = "No";

    }


    //ONCE PER FRAME
    void Update()
    {

        //IF DEADCHECK IS SET TO THE STRING "Yes"

        if (DEADCHECK.Contains("Yes"))
        {

            if (Input.anyKey)

            //WHEN ANY KEY IS PRESSED

            {
                SceneManager.LoadScene("Main");

                //LOADS THE SCENE WITH THE EXACT SAME NAME AS WHAT YOU PUT INSTEAD OF "EXACT SCENE NAME HERE"
            }
        }

        if (Input.GetKey(KeyCode.R))
        //YOU CAN CHANGE THE PART AFTER KEYCODE.R TO BE ANY KEY YOU WANT LIKE KEYCODE.F or KEYCODE.RETURN or KEYCODE.SPACE
        {
            SceneManager.LoadScene("Main");
            //LOADS THE SCENE WITH THE EXACT SAME NAME AS WHAT YOU PUT INSTEAD OF "EXACT SCENE NAME HERE"
        }
    }
}
