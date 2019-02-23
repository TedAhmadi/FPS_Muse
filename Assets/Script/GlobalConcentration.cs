using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalConcentration : MonoBehaviour {

    //public static int CurrentConcentration = 0;
    public GameObject ConcentrateDisplay;
    //public TransformMapping mm;

	// Update is called once per frame
	void Update () {
        
        //mm = GetComponent<TransformMapping>();
        //ConcentrateDisplay.GetComponent<Text>().text = "Concentration: " + mm.currentConcentrate.ToString();
        ConcentrateDisplay.GetComponent<Text>().text = "Power: " + TransformMapping.currentConcentrate.ToString(); 
	}
}
