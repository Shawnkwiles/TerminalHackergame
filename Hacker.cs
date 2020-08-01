using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        ShowMainMenu();

    }

    void ShowMainMenu() {
        var greeting = "Hey Jack";

        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What system will you break?");
        Terminal.WriteLine("Press 1 for the library");
        Terminal.WriteLine("Press 2 for the fuzz");
        Terminal.WriteLine("Enter your selection:");

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
