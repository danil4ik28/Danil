using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScriptCalculator : MonoBehaviour
{
    [SerializeField] public Text text1;
    [SerializeField] public Text text2;
    [SerializeField] public InputField inputField1;
    [SerializeField] public InputField inputField2;

    [SerializeField] private GameObject Resulttext;
    [SerializeField] private GameObject Resultbutton;

    double actionVar;

        public void Start()
    {
        Resultbutton.SetActive(true);
        Resulttext.SetActive(false);
    }
        public void OnclickPlus()
    {
        text1.text = "+";
        
    }
        public void OnclickMinus()
    {
       text1.text = "-";
        
    }
        public void OnclickDivide()
    {
    text1.text = "/";
        
    }
        public void OnclickMulti()
    {
     text1.text = "*";
        
    }
        public void OnclickEqual()
    {
        
        double FirstValueVar = Convert.ToDouble(inputField1.text);
            double SecondValueVar = Convert.ToDouble(inputField2.text);
        
        switch(text1.text)
        {
            case "+": actionVar = FirstValueVar + SecondValueVar;
                break;
            case "-":
                actionVar = FirstValueVar - SecondValueVar;
                break;
            case "/":
                actionVar = FirstValueVar / SecondValueVar;
                break;
            case "*":
                actionVar = FirstValueVar * SecondValueVar;
                break;
        }
        Resultbutton.SetActive(false);
        Resulttext.SetActive(true);

        text2.text = Convert.ToString(actionVar);
    }
    

}
