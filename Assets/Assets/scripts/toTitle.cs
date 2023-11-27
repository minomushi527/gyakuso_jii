using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class toTitle : MonoBehaviour
{

    public GameObject titleButton;
    public CountdownUI countdownui;
    private bool a = true;

    // Start is called before the first frame update
    void Start()
    {
        
        //     if(!countdownui.CheckTheClear()){
        //         Debug.Log("check ok");
        //     }
        // titleButton.SetActive(false);
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (a){
        if(countdownui.CheckTheClear()){
           titleButton.SetActive(true);
           a = false;
        }
        }
    }
}
