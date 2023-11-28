using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IfElse : MonoBehaviour
{
    //화면에 출력할 Text
    public TMP_Text text; // TMP 오브젝트 활성화
    public TMP_InputField inputField; // 사용자에게 입력을 받을 Input Field
    
    // 버튼이 클릭 되었을때 동작할 함수
   public void ButtonCliceked() 
    {
        string input = inputField.text;
        int number = int.Parse(input);

        if (number > 0)
        {
            text.text = "음수";
        }
        else if (number > 0) //여러개 가능
        {
            text.text = "양수";
        }
        else
        {
            text.text = "0";
        }
        if (number % 2 == 0)
        {
            text.text = ("짝수");
        }
        else
        {
            text.text = ("홀수");
        }
    }
    void Start()
    {
 
       
    }
}
