using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        { // While �� ����
            int i = 10;

            while (i > 0)
            {
                Debug.Log($"i : {i--}");
            }
            int j = 10;
            do //�ϴ� �ѹ� �����ϰ� �׵ڿ� ���ǿ� �°� ����(�ѹ��� �����ǽ���)
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
            foreach(int a in arr) //�ݺ��� �Ҵ���� �ݺ��� �������������־����
            {
                Debug.Log (a);
            }
        }
    }
}
