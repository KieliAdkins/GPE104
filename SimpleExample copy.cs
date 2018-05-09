using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour {

    public string theText = "Hello World";

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        // Write the value stored in our variable "theText" to the console window
        Debug.Log(theText);
	}
}
