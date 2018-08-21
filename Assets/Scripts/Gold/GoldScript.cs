using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GoldScript : MonoBehaviour
{

    public int gold;
    public Text goldText;
    // Use this for initialization
    void Start()
    {
		gold = 150;
        goldText.text = "[gold][" + gold.ToString ()+"]";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addGold(int goldToAdd)
    {
        gold += goldToAdd;
        goldText.text = "[gold][" + gold.ToString() + "]";
    }


    public bool subGold(int goldToSub)
    {
        if (gold - goldToSub < 0) {
            Debug.Log("Not enough money");
            return false; 
        } else {
            gold -= goldToSub;
            goldText.text = "[gold][" + gold.ToString() + "]";
            return true;
        }   
    }

    public void setText(string str) {
        goldText.text = str;
    }
}