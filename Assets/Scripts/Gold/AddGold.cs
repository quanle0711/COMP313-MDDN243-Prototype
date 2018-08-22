using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddGold : MonoBehaviour {
    
    public GameObject goldHold;
    public GameObject panicHold;
    private int goldToAdd;
    // Use this for initialization
    void Start () {
        goldToAdd = 5;
        InvokeRepeating("passiveCount", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (panicHold.GetComponent<PanicScript>().panic >= 50) {
            goldToAdd = 10;
        }       
	}
    void passiveCount () {
        goldHold.GetComponent<GoldScript>().addGold(goldToAdd);
    }
}
