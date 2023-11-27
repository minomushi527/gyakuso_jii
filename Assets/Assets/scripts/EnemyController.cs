using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject myCar;
    public float speed = 1.0f;

    void Start()
    {
        this.myCar = GameObject.Find("myCar");
    }

    void FixedUpdate()
    {
        //フレームごとに等速で左移動
        transform.Translate(-0.1f * speed, 0, 0);

        //画面外に出たらオブジェクトを破壊
        if (transform.position.x < -15.0f)
        {
            Destroy (gameObject);
        }
    }
}
