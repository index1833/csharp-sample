using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        // IndexOf() 교제 97페이지 위쪽 표에 나와있음

        var result = greeting.IndexOf("Good");
        result = greeting.IndexOf("o"); // 1이반환

        var result2 =  greeting.StartsWith("Good"); // bool 타입으로 

        result2 = greeting.StartsWith("Morning");

        result2 = greeting.EndsWith("Good");
        result2 = greeting.EndsWith("Morning");

        result2 = greeting.Contains("Evening");
        result2 = greeting.Contains("Morning");

        Debug.Log($"IndexOf: 'Good' : { greeting.IndexOf("Good") }");
        Debug.Log($"IndexOf: 'o' : { greeting.IndexOf("o") }");
    
        // LastIndexOf()
        Debug.Log($"LastIndexOf: 'Good' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"LastIndexOf: 'g' : { greeting.LastIndexOf("g") }");
        
        // StartWith()
        Debug.Log($"StartWith: 'Good' : { greeting.StartsWith("Good") }");
        Debug.Log($"StartWith: 'g' : { greeting.StartsWith("Morning") }");
        
        // EndWith()
        Debug.Log($"EndWith: 'Good' : { greeting.EndsWith("Good") }");
        Debug.Log($"EndtWith: 'Morning' : { greeting.EndsWith("Morning") }");

        // Contains() 특정한 문자열을 포함하고있는지...
        Debug.Log($"Contains: 'Evening' : { greeting.Contains("Evening") }");
        Debug.Log($"Contains: 'Morning' : { greeting.Contains("Morning") }");

        //Replace() 특정한 문자열을 또다른 문자열로 치환
        Debug.Log($"Replace: 'Morning' with 'Evening' : { greeting.Replace("Good", "Evening")}");
    }
    
}
