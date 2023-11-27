using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    //スタートボタンが押されたら呼ばれる
    public void PressReStart(){
        
		  SceneManager.LoadScene ("Game");
        
    }
}
