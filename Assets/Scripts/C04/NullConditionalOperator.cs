using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null; // 
        a?.Add("�߱�");       // a?. �� null�� ��ȯ�Ͽ� Add�޼ҵ尡 ȣ��������� (null)�� �ƴҰ�� ����-->Add~
        a?.Add("�౸");
        Debug.Log($"Count : {a?.Count}");   // a?��  null�� ��ȯ�ϹǷ� Count �̿ܿ��� �ƹ��͵� ������� ����
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList(); // ���̻� a�� null �� �ƴϴ� . 

         // class ---> �޸𸮻� �ö󰡸� Object����

        a?.Add("�߱�");
        a?.Add("�౸");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        Person person  = new Person(); // Person�̶�� ������ ���������ġ������(�޸��Ҵ�)

        person.Walk();
    }
}

public class Person
{
    // ���� 
    int age;
    // + 
    // �Լ� 
    public void Walk()
    {

    }
}
