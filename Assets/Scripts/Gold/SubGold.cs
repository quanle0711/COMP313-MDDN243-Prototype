using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGold : MonoBehaviour {

    public GameObject goldHold;
    // Use this for initialization
    void Start()
    {
        goldHold = GameObject.FindGameObjectWithTag("GoldCount");
    }

    // Update is called once per frame
    void onMouseDown()
    {
        goldHold.GetComponent<GoldScript>().subGold(50);
    }	
}
