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
        goldText.text = gold.ToString ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addGold(int goldToAdd)
    {
        gold += goldToAdd;
        goldText.text = gold.ToString();
    }

    public void subGold(int goldToSub)
    {
        if (gold - goldToSub < 0) {
            Debug.Log("Not enough money");
        } else {
            gold -= goldToSub;
            goldText.text = gold.ToString();
            
        }   
    }
}