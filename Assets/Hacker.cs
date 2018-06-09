using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game State
        int level;


    // Use this for initialization
    void Start () {
        ShowMainMenu("Hello Maayan");
    }

    void ShowMainMenu (string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for local library");
        Terminal.WriteLine("Press 2 for police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput (string input) {

        if(input == "menu")
        {
            ShowMainMenu("Main Menu");
        }

        if(input == "1")
        {
            level = 1;
            StartGame();

        }

        else if (input == "2")
        {
            level = 2;
            StartGame();
        }

        else if (input == "3")
        {
            level = 3;
            StartGame();
        }

        else if (input == "007")
        {
            Terminal.WriteLine("Please choose a valid level, MR. Bond");
        }

        else
        {
            Terminal.WriteLine("Please choose a valid level!");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password:");
    }   

}
