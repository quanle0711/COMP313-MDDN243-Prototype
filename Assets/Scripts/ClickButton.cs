using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour {
	// Update is called once per frame
	MeshRenderer MR;
	void OnMouseDown() {
		MR = GetComponent<MeshRenderer> ();
		gameObject.transform.GetChild(0).gameObject.SetActive(true);
		MR.enabled = false;
	}
}
