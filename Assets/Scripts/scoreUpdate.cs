using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour {

    //int count = 0;
    public Text score = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Score : " + staticArray.score.ToString();
	}
}
