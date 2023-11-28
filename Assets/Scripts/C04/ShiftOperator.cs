using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Testing <<....");

        int a = 1; // 4byte 32bit공간에 뒤에가 1이되고 나머지는 0

        // layer는 32bit로 구성되어있음

        Debug.Log(string.Format("a : {0:D5} (0x{0:X8})", a));
        Debug.Log(string.Format("a << 1 :{0:D5} (0x{0:X8})", a << 1));
        Debug.Log(string.Format("a << 2: {0:D5} (0x{0:X8})", a << 2));
        Debug.Log(string.Format("a << 5: {0:D5} (0x{0:X8})", a << 5));

        Debug.Log("Testing <<....");

        int b = 255;

        Debug.Log(string.Format("b << : {0:D5} (0x{0:X8})", b));
        Debug.Log(string.Format("b << 1 :{0:D5} (0x{0:X8})", b << 1));
        Debug.Log(string.Format("b << 2: {0:D5} (0x{0:X8})", b << 2));
        Debug.Log(string.Format("b << 5: {0:D5} (0x{0:X8})", b << 5));

        Debug.Log("Testing <<....");

        int c = -255;

        Debug.Log(string.Format("c << : {0:D5} (0x{0:X8})", c));
        Debug.Log(string.Format("c << 1 :{0:D5} (0x{0:X8})", c << 1)); //D는 10진수 == 첫번째 값은 10진수로 표현하는데 값을 5를넣어라
        Debug.Log(string.Format("c << 2: {0:D5} (0x{0:X8})", c << 2));
        Debug.Log(string.Format("c << 5: {0:D5} (0x{0:X8})", c << 5));


    }
}
