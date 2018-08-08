using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveUpOnClick : MonoBehaviour {

	public float speed;
	public int minHeight;

	private Vector3 destination;
	private float randHeight;
	void Start () {
		randHeight = Random.Range (2f, 5f);
		//random height between 2 and 5;
		transform.localScale = new Vector3 (1f,randHeight * 10f,1f);
		destination = transform.parent.position + new Vector3 (0,(randHeight/2), 0);
	}

	void Update () {
		if (isActiveAndEnabled == true) {
			// If the object is not at the target destination
			if (destination != gameObject.transform.position) {
				// Move towards the destination each frame until the object reaches it
				IncrementPosition ();
			}
		}

	}

	void IncrementPosition ()
	{
		// Calculate the next position
		float delta = speed * Time.deltaTime;
		Vector3 currentPosition = gameObject.transform.position;
		Vector3 nextPosition = Vector3.MoveTowards (currentPosition, destination, delta);

		// Move the object to the next position
		gameObject.transform.position = nextPosition;
	}
}
