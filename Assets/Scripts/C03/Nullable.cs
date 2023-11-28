using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nullable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
        int? a = null;

        Debug.Log(a.HasValue);
        Debug.Log(a != null);

        a = 3;

        Debug.Log(a.HasValue);
        Debug.Log(a != null);
        Debug.Log(a.Value); // 실제 a의 값을 끌고옴
        }

        {
            var a = 20; //선언과 동시에 선언된 해당변수의 변수의 형식을 지정
            Debug.Log($"Type: {a.GetType()} , Value: {a}");
            var b = 3.1414213; // 실수값을받을때는 큰사이즈로 ==> double값으로
            Debug.Log($"Type: {b.GetType()} , Value: {b}");
            var c = "Hello";
            Debug.Log($"Type: {c.GetType()} , Value: {c}");
            var d = new int[]{10,20,30};
            foreach (var e in d){
                Debug.Log(e);
            }
        }
    }
}
