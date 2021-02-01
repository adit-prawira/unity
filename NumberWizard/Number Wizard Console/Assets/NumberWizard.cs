using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 1, max = 1000;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number you can pick is: " + max);
        Debug.Log("Lowest number you can pick is: " + min);
        Debug.Log("tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Down");
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter");
        }

    }
}
