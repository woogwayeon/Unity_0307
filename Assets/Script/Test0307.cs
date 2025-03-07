using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test0307 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("nomal");
        Debug.LogWarning("Warning");
        Debug.LogError("Err");
        */

        /*
        for(int i=0; i<100; i++)
        {
            Debug.Log("sameLog");
        }
        */

        // print("hello world");

        // Debug.Log(1);
        // Debug.Log(10);
        // Debug.Log(-20);

        // Debug.Log(0.1);
        // Debug.Log(3.141592);
        // Debug.Log(-10.24);

        // 정수형 자료를 저장하기 위한 변수 만들기
        int life;
        life = 3;
        Debug.Log(life);

        life = 2;
        Debug.Log(life);

        float time = 9.9f;
        Debug.Log(time);

        time = 0.1f;
        Debug.Log(time);

        double time_d = (double) time;
        Debug.Log(time);

        time_d = (int) time_d;
        Debug.Log(time);

        string time_str = time.ToString();
        Debug.Log(time_str); 

        string time_d_str = time_d.ToString();
        Debug.Log(time_d_str);

        time = int.Parse("12");
        Debug.Log(time);

        time_d = double.Parse("12.34");
        Debug.Log(time_d);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
