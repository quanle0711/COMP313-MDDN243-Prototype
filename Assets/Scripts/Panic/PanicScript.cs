using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanicScript : MonoBehaviour {

	// Use this for initialization
	public int panic;
	public Text panicText;
	// Use this for initialization
	void Start()
	{
		panicText.text = "[panic][" + panic.ToString ()+"]";
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void addPanic(int p)
	{
		panic += p;
		panicText.text = "[panic][" + panic.ToString ()+"]";
	}
		
	public void setText(string str) {
		panicText.text = str;
	}
}
