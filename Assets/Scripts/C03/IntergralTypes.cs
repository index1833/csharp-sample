using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace C0301
{
    public class IntergralTypes : MonoBehaviour
    {
    // Start is called before the first frame update
        void Start()
        {
            // {
            // sbyte a = -10;
            // byte b = 40;

            // Debug.Log($"a={a}, b={b}");

            // short c = -30000;
            // ushort d = 60000;

            // Debug.Log($"c={c}, d={d}");

            // int e = -1000_0000;
            // uint f = 3_0000_0000; //숫자쓰기쉽게 중간에 _

            // Debug.Log($"e={e}, f={f}");

            // long g = -5000_0000_0000;
            // ulong h = 200_0000_0000_0000_0000;

            // Debug.Log($"g={g}, h={h}");

            // Debug.Log(string.Format("g = {0} , h= {1} ", g,h));
            // }

            // { 
            // byte a = 255; // 부호값을 안씀(-)
            // sbyte b = (sbyte)a; // 변환하고자하는 타입의 변수앞에 () 변환 했을때 값이 달라짐

            // Debug.Log(a);
            // Debug.Log(b);
            // }

            // {
            //     uint a = uint.MaxValue;
            //     Debug.Log(a);

            //     a = a + 1; // stackoverflow Max값에 +1을했기떄문에 

            //     Debug.Log(a);
            // }
            {
                float a = 3.1415_9265_3589_7932_3846f;
                Debug.Log(a);

                double b = 3.1415_9265_3589_7972_3846;
                Debug.Log(b);

                decimal c = 3.1415_9265_3589_7972_3846_3444_3555_4555m;
                Debug.Log(c);
            }
        }
    }  
}

