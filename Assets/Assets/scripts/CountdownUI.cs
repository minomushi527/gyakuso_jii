using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class CountdownUI : MonoBehaviour
{
    public float countdownTime = 30f; // カウントダウンする時間（秒）
    public TextMeshProUGUI countdownText;
    public GameObject mycar;
    public GameObject enemycar;
    private bool clear = false;
    private int a = 0;

    public bool CheckTheClear(){
        return this.clear;
    }

    void Start()
    {
        //countdownText = GetComponent<Text>();
        StartCoroutine(StartCountdown());
    }

    private void FixedUpdate()
    {
        if (clear && a == 0){
            Destroy(enemycar);
            mycar.GetComponent<Rigidbody2D>().simulated = false;
            mycar.transform.Translate(0.1f, 0, 0);
            mycar.GetComponent<PlayerController>().enabled = false;
            if (mycar.transform.position.x > 10.0f)
            {
            Destroy (mycar);
            ++a;
            }
            
        }
    }

    IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            //countdownText.text = "Time: " + countdownTime.ToString("F0"); // 小数点以下の桁を表示しない形式でテキスト更新
            countdownText.GetComponent<TextMeshProUGUI>().text = "Time: " + countdownTime.ToString("F0");
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownText.text = ""; // カウントダウン終了
        clear = true;
    }
}