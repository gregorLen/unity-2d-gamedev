using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber = 1000;   // instance variable -> can be acessable in other methods
    int minNumber = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxNumber = 1000;
        minNumber = 0;
        guess = 500;

        Debug.Log("Welcome to NumberWizard, my friend. Pick a number between " + minNumber + " and " + maxNumber);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push down = Lower ;) ");
        maxNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        { 
            Debug.Log("Number is higher? okay.");
            minNumber = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Number is lower? okay.");
            maxNumber = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Good Game! That was fun");
            StartGame();
        }  
    }

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is your number higher or lower than" + guess + "?");
    }

}
