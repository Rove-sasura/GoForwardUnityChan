using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    
    public GameObject cubePrefab;


    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
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
