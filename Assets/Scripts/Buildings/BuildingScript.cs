using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BuildingScript : MonoBehaviour {

    public float speed;
    public int minHeight;

    private Vector3 destination;
    private float randHeight;
    //display hit points
    private int hitpoints;
	private GameObject Panic;

    void Start()
    {
        speed = 10;
        minHeight = 1;
		hitpoints = 250;

		Panic = GameObject.FindGameObjectWithTag ("PanicCount");

		//animation for buildings
		randHeight = Random.Range(1f, 2f);
        //random height between 1 and 2;
        transform.localScale = new Vector3(1f, randHeight * 10f, 1f);
        destination = transform.parent.position + new Vector3(0, (randHeight), 0);
    }


    void Update()
    {
        if (isActiveAndEnabled == true)
        {
            // If the object is not at the target destination
            if (destination != gameObject.transform.position)
            {
                // Move towards the destination each frame until the object reaches it
                IncrementPosition();
            }

        }

    }

	private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Giant"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(3500, 0, 3500, ForceMode.Impulse);
            hitpoints -= 50;
            changeColorHP();
            if (hitpoints == 0)
            {
                transform.parent.GetComponent<Renderer>().enabled = true;
                Panic.GetComponent<PanicScript>().addPanic(10);
                DestroyObject(gameObject);
            }
            
        }
    }

    void IncrementPosition()
    {
        // Calculate the next position
        float delta = speed * Time.deltaTime;
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 nextPosition = Vector3.MoveTowards(currentPosition, destination, delta);

        // Move the object to the next position
        gameObject.transform.position = nextPosition;
    }
		
	void changeColorHP() {
		Renderer rd = GetComponent<Renderer> ();
		if (hitpoints == 250) {
			rd.material.color = Color.yellow;
		} else if (hitpoints == 150) {
			rd.material.color = Color.magenta;
		} else if (hitpoints == 50) {
			rd.material.color = Color.red;
		}
	}
}
