using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null; // 
        a?.Add("야구");       // a?. 가 null을 반환하여 Add메소드가 호출되지않음 (null)이 아닐경우 실행-->Add~
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");   // a?가  null을 반환하므로 Count 이외에는 아무것도 출력하지 않음
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList(); // 더이상 a는 null 이 아니다 . 

         // class ---> 메모리상에 올라가면 Object가됌

        a?.Add("야구");
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        Person person  = new Person(); // Person이라는 변수에 만들어진위치값저장(메모리할당)

        person.Walk();
    }
}

public class Person
{
    // 변수 
    int age;
    // + 
    // 함수 
    public void Walk()
    {

    }
}
