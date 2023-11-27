using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    //スクロールスピード
    [SerializeField]
    float speed = 1;

    void Update()
    {
        //右方向にスクロール
        transform.position -= new Vector3(Time.deltaTime * speed, 0);

        //Xが-11まで来れば、21.33まで移動する
        if (transform.position.x <= -23f)
        {
            transform.position = new Vector2(23f, 0);
        }
    }
}
