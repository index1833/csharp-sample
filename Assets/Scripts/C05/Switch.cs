using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class Switch : MonoBehaviour
{
    public TMP_Text text;
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        
      
    }
    public void OnText()
    {
        string day = "��";
  

        switch (day)
        {
            case "��":
                Debug.Log("Sunday");
                break;

            case "��":
                Debug.Log("Monday");
                break;

            case "ȭ":
                Debug.Log("Tuesday");
                break;

            case "��":
                Debug.Log("Wednesday");
                break;

            case "��":
                Debug.Log("Thursday");
                break;

            case "��":
                Debug.Log("Friday");
                break;

            case "��":
                Debug.Log("Saturday");
                break;

            default:
                Debug.Log($"{day}��(��) ������ �ƴմϴ�.");
                break;
        }
    }
}
