using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clearappeal : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI clearText;
    public GameObject mycar;
    public CountdownUI countdownui;

    // Update is called once per frame
    void Update()
    {
        if(countdownui.CheckTheClear()){
            Debug.Log("check");
           clearText.text = "Clear!!";
        }
        
    }


}
