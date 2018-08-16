using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour {
	// Update is called once per frame
	MeshRenderer MR;
	void OnMouseDown() {
        GameObject building = GameObject.CreatePrimitive(PrimitiveType.Cube);
        building.transform.Translate(transform.position);
        building.AddComponent<MoveUpOnClick>();

        // Assigns a material named "Assets/Resources/DEV_Orange" to the object.
        Renderer newMat = building.GetComponent<Renderer>();
        newMat.material = Resources.Load("building", typeof(Material)) as Material;
        building.transform.parent = transform;
        MR.enabled =false;
    }
}
