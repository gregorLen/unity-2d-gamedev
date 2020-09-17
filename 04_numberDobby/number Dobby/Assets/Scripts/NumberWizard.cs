using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int maxNumber;   
    [SerializeField]int minNumber;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        minNumber = guess+1;
        NextGuess();
    }
    public void OnPressLower()
    { 
        maxNumber = guess-1;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(minNumber, maxNumber + 1);// (maxNumber + minNumber) / 2;
        guessText.text = guess.ToString();
    }

}
