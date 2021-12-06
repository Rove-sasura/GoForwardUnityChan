using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    
    public GameObject cubePrefab;


    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (Collision.gameObject.tag == "UnityChan")
    //    {
    //        GetComponent<AudioSource>().Play();
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    GetComponent<AudioSource>().volume = (collision.gameObject.tag == UnityChan) ? 0 : 1;
    //}

}
