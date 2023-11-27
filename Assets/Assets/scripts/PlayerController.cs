using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PlayerController : MonoBehaviour
{
    

    float vx = 0;

    float vy = 0;

    public float movespeed = 30;

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()
    {
        //毎フレーム数値を初期化
        vx = 0;
        vy = 0;

        // もし右矢印を押したら、右に移動する
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vx = movespeed;
        }

        // もし左矢印を押したら、左に移動する
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vx = -1 * movespeed;
        }

        // もし上矢印を押したら、上に移動する
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vy = movespeed;
        }

        // もし下矢印を押したら、下に移動する
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vy = -1 * movespeed;
        }

        this.transform.Translate(vx / 10, vy / 10, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("car"))
        {
            //Invoke("DelayMethod", 3.5f);
            //other.gameObject.SetActive(false);
            SceneManager.LoadScene ("gameover");
        }
        
    }
}
