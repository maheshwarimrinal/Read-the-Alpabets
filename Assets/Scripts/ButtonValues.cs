using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonValues : MonoBehaviour {

    public Text finalText;
    public Button button_1;
    public Button button_2;
    public Button button_3;
    public Button button_4;
    public Button button_5;
    public Button button_6;
    public Button button_7;
    public Button button_8;
    public Button button_9;

    public Text button1_text;
    public Text button2_text;
    public Text button3_text;
    public Text button4_text;
    public Text button5_text;
    public Text button6_text;
    public Text button7_text;
    public Text button8_text;
    public Text button9_text;
    public string text;

    int totalValues;

    void Start () {
        button1_text.text = "wow";
        button2_text.text = "hello";
        button3_text.text = "how";
        button4_text.text = "now";

        button_1.GetComponent<Button>().onClick.AddListener(func_1);
        button_2.GetComponent<Button>().onClick.AddListener(func_2);
        button_3.GetComponent<Button>().onClick.AddListener(func_3);
        button_4.GetComponent<Button>().onClick.AddListener(func_4);
        button_5.GetComponent<Button>().onClick.AddListener(func_5);
        button_6.GetComponent<Button>().onClick.AddListener(func_6);
        button_7.GetComponent<Button>().onClick.AddListener(func_7);
        button_8.GetComponent<Button>().onClick.AddListener(func_8);
        button_9.GetComponent<Button>().onClick.AddListener(func_9);
    }

    public void func_1(){
        text = text + " wow";
        finalText.text = text;
    }

    public void func_2()
    {
        text = text + " hello";
        finalText.text = text;
    }

    public void func_3(){
        text = text + " how";
        finalText.text = text;
    }

    public void func_4(){
        text = text + " now";
        finalText.text = text;
    }

    public void func_5(){
        text = text + " now";
        finalText.text = text;
 
    }

    public void func_6(){
        text = text + " now";
        finalText.text = text;

    }

    public void func_7(){
        text = text + " now";
        finalText.text = text;
         
    }

    public void func_8(){
        text = text + " now";
        finalText.text = text;

    }

    public void func_9(){
        text = text + " now";
        finalText.text = text;
         
    }

    // Update is called once per frame
	void Update () {

	}
}
