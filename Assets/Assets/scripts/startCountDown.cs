using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startCountDown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float countdownTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    { 
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    IEnumerator StartCountdown()
    {
        while (countdownTime >= 0)
        {
            if(countdownTime > 0){
            countdownText.text =  countdownTime.ToString("F0");
            }
            else{
                countdownText.text =  "Start!";
            }
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        SceneManager.LoadScene ("Game");
    }
}
