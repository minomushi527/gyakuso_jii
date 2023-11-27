using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject yellowCarPrefab;

    public float span = 1.0f;

    float delta = 0;
    

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(yellowCarPrefab);
            int py = Random.Range(-4, 3);
            go.transform.position = new Vector3(13, py, 0);
        }
    }
}
