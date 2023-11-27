using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float time = 30;
    CountdownUI count;

    public TextMeshProUGUI scoreText;


    void start(){
        float a = time - count.countdownTime;
        scoreText.text = "Score : " + a;
    }
}
