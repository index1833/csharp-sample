
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using C0301;

public class StringSlice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";

        Debug.Log(greeting.Substring(0,5));
        Debug.Log(greeting.Substring(5));

        string[] arr = greeting.Split(new string[] {" "} , StringSplitOptions.None); 
        // 문자열의 공백이있으면 그 기준으로 자르겠다...라는조건--> 문자열을쪼갰을때 빈문자열이 있어도 허용  ,System. 을써줘야 사용할수있음 (위에 using으로 사용하도됌)
        foreach(string element in arr)
            Debug.Log($"{element}");
    }
}

