using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInitLower : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int row = 0; row < 6; row++)
        {
            for (int col = 0; col < 6; col++)
            {
                GameObject button = GameObject.CreatePrimitive(PrimitiveType.Cube);
                button.transform.localScale = new Vector3(5f, 0.2f, 5f);
                button.transform.Translate(-12.5f + (5.0f * row), 2.6f, -12.5f + (5.0f * col));
                button.AddComponent<ButtonClickDefense>();

                //renderer
                Renderer newMat = button.GetComponent<Renderer>();
                newMat.material = Resources.Load("Materials/top_grass", typeof(Material)) as Material;

                //add button to parent            
                button.transform.parent = transform;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
