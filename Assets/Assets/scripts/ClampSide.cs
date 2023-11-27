using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampSide : MonoBehaviour
{   
    CountdownUI countdownUI;
    void Start()
    {
        
    }

    // x軸方向の移動範囲の最小値
    [SerializeField] private float _minX = -8;

    // x軸方向の移動範囲の最大値
    [SerializeField] private float _maxX = 15;
        // y軸方向の移動範囲の最小値
    [SerializeField] private float _minY = -3;

    // y軸方向の移動範囲の最大値
    [SerializeField] private float _maxY = 3;

    private void Update()
    {

        //countdownUI = GetComponent<CountdownUI>();
        //bool gogorightFromCountdownUI = countdownUI.gogoright; // countdownUIの変数を取得

        var pos = transform.position;
        // x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);
        // y軸方向の移動範囲制限
        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);

        //if(!gogorightFromCountdownUI){
        transform.position = pos;
        //}
        
    }
    }
