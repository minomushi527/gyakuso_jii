using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startbottan : MonoBehaviour
{
    //スタートボタンが押されたら呼ばれる
    public void PressStart(){
        
		SceneManager.LoadScene ("monologue");
        
    }
}
