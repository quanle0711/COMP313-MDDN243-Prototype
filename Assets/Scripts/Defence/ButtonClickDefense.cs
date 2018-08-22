using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ButtonClickDefense : MonoBehaviour {

    private Renderer renderer;
    private Color startcolor;
    private GameObject goldHold;
    public GameObject equipPrefab;
    //public List<GameObject> createdObjects = new List<GameObject>();
    //private float minX, maxX, minY, maxY;

    // Use this for initialization
    MeshRenderer MR;

    private void Start()
    {
        MR = GetComponent<MeshRenderer>();
        renderer = GetComponent<Renderer>();
        goldHold = GameObject.FindGameObjectWithTag("GoldCount");
    }

    void OnMouseEnter()
    {
        startcolor = renderer.material.color;
        renderer.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        renderer.material.color = startcolor;
    }

    void OnMouseDown()
    {
        
        if (goldHold.GetComponent<GoldScript>().subGold(20))
        {
            //tower base
            GameObject TowerBase = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            TowerBase.transform.localScale = new Vector3(1f, 1.5f, 1f);
            TowerBase.transform.Translate(transform.position + new Vector3(0f,1.5f,0f));
            TowerBase.GetComponent<Collider>().isTrigger = true;

            Renderer newMat = TowerBase.GetComponent<Renderer>();
            newMat.material = Resources.Load("Materials/Cannon", typeof(Material)) as Material;
            TowerBase.transform.parent = transform;
            
            //cannon barrel
            GameObject TowerBarrel = GameObject.CreatePrimitive(PrimitiveType.Cube);
            TowerBarrel.transform.localScale = new Vector3(1f, 1f, 2f);
            TowerBarrel.transform.Translate(transform.position + new Vector3(0.31f, 3.5f, 0.4f));
            TowerBarrel.GetComponent<Collider>().isTrigger = true;


            Renderer barrelMat = TowerBarrel.GetComponent<Renderer>();
            barrelMat.material = Resources.Load("Materials/Cannon", typeof(Material)) as Material;
            TowerBarrel.transform.parent = TowerBase.transform;
            TowerBarrel.AddComponent<CannonController>();
        }
        else
        {
            goldHold.GetComponent<GoldScript>().setText("not enough gold!");
        }
    }

    /**
    private Renderer renderer;
    private Color startcolor;
	public GameObject equipPrefab;
	public List<GameObject> createdObjects = new List<GameObject>();
	private float minX, maxX, minY, maxY;
    // Use this for initialization
	MeshRenderer MR;

	void OnMouseDown() {
		MR = GetComponent<MeshRenderer>();
		GameObject goldHold = GameObject.FindGameObjectWithTag("GoldCount");
		if (goldHold.GetComponent<GoldScript>().subGold(20))
		{
			
			MR.enabled = false;
		}
		else {
			goldHold.GetComponent<GoldScript>().setText("not enough gold!");
		}
	}
    void Start () {
        renderer = GetComponent<Renderer>();
			// get the screen bounds
			float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
			Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
			Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));

			minX = bottomCorner.x;
			maxX = topCorner.x;
			minY = bottomCorner.y;
			maxY = topCorner.y;
		}

	
	// Update is called once per frame
	void Update () {
		
	}    
    
	public void CreateObject() {
		if (equipPrefab != null) {
			Vector3 position = new Vector3(Random.Range(minX + 0.5f, maxX - 0.5f), Random.Range(minY + 0.5f, maxY - 0.5f), 0);
			{ GameObject go = (GameObject)Instantiate(equipPrefab, position, Quaternion.identity);
				createdObjects.Add(go);
			}
		}
	}

    */
}
