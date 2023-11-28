using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace C06
{
    public class Calculator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //int result = MyCalculator.Plus(3, 4);
            //Debug.Log(result);

            //result = MyCalculator.Minus(5, 2);
            //Debug.Log(result); static 넣으면 이거

            MyCalculator myCalculator = new MyCalculator();

            int result;

            result = myCalculator.Plus(3, 4);
            result = myCalculator.Minus(3, 4);
        }

    }
    public class MyCalculator
    {
        public  int Plus(int a, int b) // void == 반환값이 void일때는 아무런값도 안받음 (static) 맴버변수에 접근하지않을경우 static이 유리
        {
            return a + b;
            // int result = a + b;
            // return result;
        }

        public  int Minus(int a, int b) // static 으로 선언한 메소드는 메모리할당안해도 동작함 --> 클래스명으로 접근
        {
            return a - b;
        }
    }
}
