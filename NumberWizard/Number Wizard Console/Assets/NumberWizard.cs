using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        
    }

    void StartGame(){
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number you can pick is: " + max);
        Debug.Log("Lowest number you can pick is: " + min);
        Debug.Log("tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NextGuess();
            
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NextGuess();
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter");
            // Reset the game
            StartGame();
        }
        
    }

    void NextGuess(){
        guess = (max + min)/2;
        Debug.Log("Is it higher or lower than..."+guess);
    }
}
