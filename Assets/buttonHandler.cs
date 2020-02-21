using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Calculator;

public class buttonHandler : MonoBehaviour
{

    public InputField number1;
    public InputField number2;
    
    public Text resultText;

    public Button addButtonClick;
    public Button subButtonClick;

    void Start()
    {
        addButtonClick.onClick.AddListener(add);
        subButtonClick.onClick.AddListener(sub);
    }

    public void add()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        Calculate cal = new Calculate();
        resultText.text = "Result : " + cal.Add(a, b).ToString();
    }

    public void sub()
    {
        int a = int.Parse(number1.text);
        int b = int.Parse(number2.text);
        Calculate cal = new Calculate();
        resultText.text = "Result : " + cal.Sub(a, b).ToString();
    }

    void Update()
    {
    }
}