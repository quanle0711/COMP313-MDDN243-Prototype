using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddSubGold : MonoBehaviour {
    
    public GameObject goldHold; 

	// Use this for initialization
	void Start () {
        InvokeRepeating("passiveCount", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown ("Fire1")) {
            goldHold.GetComponent<GoldScript>().subGold(50);
        }
            
	}
    void passiveCount () {
        goldHold.GetComponent<GoldScript>().addGold(1);
    }
}
