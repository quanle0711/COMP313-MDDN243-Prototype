using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddGold : MonoBehaviour {
    
    public GameObject goldHold; 

	// Use this for initialization
	void Start () {
        InvokeRepeating("passiveCount", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {   
	}
    void passiveCount () {
        goldHold.GetComponent<GoldScript>().addGold(5);
    }
}
