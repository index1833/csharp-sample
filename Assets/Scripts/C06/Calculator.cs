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
            //Debug.Log(result); static ������ �̰�

            MyCalculator myCalculator = new MyCalculator();

            int result;

            result = myCalculator.Plus(3, 4);
            result = myCalculator.Minus(3, 4);
        }

    }
    public class MyCalculator
    {
        public  int Plus(int a, int b) // void == ��ȯ���� void�϶��� �ƹ������� �ȹ��� (static) �ɹ������� ��������������� static�� ����
        {
            return a + b;
            // int result = a + b;
            // return result;
        }

        public  int Minus(int a, int b) // static ���� ������ �޼ҵ�� �޸��Ҵ���ص� ������ --> Ŭ���������� ����
        {
            return a - b;
        }
    }
}
