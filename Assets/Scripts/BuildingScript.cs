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
    private GameObject HPText;

    void Start()
    {
        speed = 10;
        minHeight = 1;
        Create3DText();
        hitpoints = 300;
        HPText.GetComponent<TextMesh>().text = hitpoints.ToString();
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

    private void OnTriggerStay(Collider other)
    {
        hitpoints--;
        HPText.GetComponent<TextMesh>().text = hitpoints.ToString();
        if (hitpoints < 0) {
            transform.parent.GetComponent<Renderer>().enabled = true;
            DestroyObject(gameObject);           
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

    private void Create3DText()
    {
        HPText = new GameObject("myText");
        HPText.AddComponent<TextMesh>();
        HPText.transform.parent = transform;
    }
}
