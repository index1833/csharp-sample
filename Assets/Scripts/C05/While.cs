using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        { // While 문 예제
            int i = 10;

            while (i > 0)
            {
                Debug.Log($"i : {i--}");
            }
            int j = 10;
            do //일단 한번 실행하고 그뒤에 조건에 맞게 실행(한번은 무조건실행)
            {
                Debug.Log($"j : {j--}");
            }
            while (j > 0);
        }
        { 
            for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                       Debug.Log("*");
                 }
                 Debug.Log($"");
             }
        }
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach(int a in arr) //반복을 할대상이 반복할 형식을가지고있어야함
            {
                Debug.Log (a);
            }
        }
    }
}
