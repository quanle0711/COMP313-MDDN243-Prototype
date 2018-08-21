using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour {
	// Update is called once per frame
	MeshRenderer MR;
	void OnMouseDown() {
        MR = GetComponent<MeshRenderer>();
        GameObject goldHold = GameObject.FindGameObjectWithTag("GoldCount");
        if (goldHold.GetComponent<GoldScript>().subGold(50))
        {
            GameObject building = GameObject.CreatePrimitive(PrimitiveType.Cube);
            building.transform.Translate(transform.position);
            building.AddComponent<BuildingScript>();
            building.GetComponent<Collider>().isTrigger = true;

            // Assigns a material named "Assets/Resources/DEV_Orange" to the object.
            Renderer newMat = building.GetComponent<Renderer>();
            newMat.material = Resources.Load("Materials/building", typeof(Material)) as Material;
            building.transform.parent = transform;
            MR.enabled = false;
        }
        else {
            goldHold.GetComponent<GoldScript>().setText("not enough gold!");
        }
    }
}
