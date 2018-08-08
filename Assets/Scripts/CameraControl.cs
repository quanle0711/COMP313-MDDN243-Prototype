using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    
    protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject axis;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) OrbitTower(false);
        if (Input.GetKey(KeyCode.LeftArrow)) OrbitTower(true);
    }

    protected void OrbitTower(bool bLeft)
    {

        /* This is for smoother camera controls if we need them
         * 
         * 
        float step = fSpeed * Time.deltaTime;
        float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
        float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
        */

        if (bLeft)  transform.RotateAround(axis.transform.position, Vector3.up, -50.0f * Time.deltaTime);
        else        transform.RotateAround(axis.transform.position, Vector3.up, 50.0f * Time.deltaTime);
    }
}
