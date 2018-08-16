using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInitialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int row = 0; row < 4; row++) {
            for (int col = 0; col < 4; col++) {
                GameObject button = GameObject.CreatePrimitive(PrimitiveType.Cube);
                button.transform.localScale = new Vector3(2f, 0.2f, 2f);
                button.transform.Translate(-6f + (4.0f * row), 5.35f, -6f + (4.0f * col));
                //script temp = Resources.Load("Scripts/ClickButton") as script;
                //script sc = button.AddComponent<script>() as script;
                button.AddComponent<ClickButton>();
               

                //add button to parent
                button.transform.parent = transform;
            }
        } 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
