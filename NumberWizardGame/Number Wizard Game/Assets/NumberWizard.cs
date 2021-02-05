using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        
    }
    void StartGame(){
        max += 1;
    }
    public void onPressHigher(){
        min = guess;
        NextGuess();
    }
    public void onPressLower(){
        max = guess;
        NextGuess();
    }        
    void NextGuess(){
        guess = (max + min)/2;
    }
}
