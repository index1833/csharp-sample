using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    enum DialogResult { YES , NO , CANCEL , CONFIRM, OK} //0~4까지의 값 순서대로 한정된값을지정해서 그범위내에서 값을 사용하고자 할때
    // Start is called before the first frame update
    void Start()
    {
        {
            string a = "안녕하세요"; // 서버에 호출할때 많이 씀(앱과 서버연동)
            string b = "홍길동입니다";

            Debug.Log(a);
            Debug.Log(b);
        }

        {
            int a = 123;
            string b = a.ToString(); // int 값을 String값으로 숫자를 문자열로
            Debug.Log(b);

            float c = 3.14f;
            string d = c.ToString();
            Debug.Log(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Debug.Log(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Debug.Log(h);
        }

        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483647;
            
            Debug.Log(MAX_INT);
            Debug.Log(MIN_INT);
        }

        {  //Enum1
            Debug.Log((int)DialogResult.YES);
            Debug.Log((int)DialogResult.NO);
            Debug.Log((int)DialogResult.CANCEL);
            Debug.Log((int)DialogResult.CONFIRM);
            Debug.Log((int)DialogResult.OK);
        }

        { //Enum2
            DialogResult result = DialogResult.YES; //Enum타입을 변수타입으로 할당 타입을 직접 만듬

            Debug.Log(result == DialogResult.YES);
            Debug.Log(result == DialogResult.NO);
            Debug.Log(result == DialogResult.CANCEL);
            Debug.Log(result == DialogResult.CONFIRM);
            Debug.Log(result == DialogResult.OK);
        }
    }
}
