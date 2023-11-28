using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellowWorld : MonoBehaviour
{ // 클래스의 멤버변수
    string name = "SANS"; // 변수는 선언되었을때 메모리에 생성(hello라는 script가 사라지기전까지는 존재) == 꾸준히 유지
    public float MoveSpeed = 5.0f;

    void Start() // SCript가 할당된 오브젝트가 화면에 나타날때, 메모리에 올라갈때 사용 (1번)
    {
        int age; // age는 시작하고 사라짐
        age = 1; //age에 1값 할당.....

        Run(); // 함수 실행
        Debug.Log("시작");
    
    }

    void Run()
    {
        //동작 넣기
        Debug.Log("뛰는중");
    }
}
