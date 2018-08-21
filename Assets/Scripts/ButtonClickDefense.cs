using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickDefense : MonoBehaviour {
    private Renderer renderer;
    private Color startcolor;
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}    
    void OnMouseEnter()
    {
        startcolor = renderer.material.color;
        renderer.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        renderer.material.color = startcolor;
    }
}
