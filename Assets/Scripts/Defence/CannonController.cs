using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    private GameObject cannonball;
    private GameObject PanicHold;
    private int panicFirerate;
    // Use this for initialization
    void Start()
    {
        panicFirerate = 1;
        PanicHold = GameObject.FindGameObjectWithTag("PanicCount");
        cannonball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        InvokeRepeating("LaunchProjectile", 0.1f, 1.0f);
    }

    void LaunchProjectile()
    {
        GameObject instance = Instantiate(cannonball,transform.position,transform.rotation);
        //material
        Renderer newMat = instance.GetComponent<Renderer>();
        newMat.material = Resources.Load("Materials/CannonBall", typeof(Material)) as Material;

        //where the fun begins
        instance.AddComponent<Rigidbody>();
        instance.AddComponent<CannonDeinit>();
        instance.transform.localScale = new Vector3(1f, 1f, 1f);
        instance.GetComponent<Rigidbody>().mass = 500;
        GameObject target = GameObject.FindGameObjectWithTag("Giant");
        instance.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Random.Range(-4f,4f), Random.Range(-3f, 3f), 100);

   
    }

    // Update is called once per frame
    void Update() {
        GameObject target = GameObject.FindGameObjectWithTag("Giant");
        transform.LookAt(target.transform);
        int NewpanicFirerate;
        if (PanicHold.GetComponent<PanicScript>().panic >= 70)
        {
            NewpanicFirerate = 2;
        }
        else {
            NewpanicFirerate = 1;
        }

        if (panicFirerate != NewpanicFirerate) { 
        InvokeRepeating("LaunchProjectile", 0.1f, 1.0f / NewpanicFirerate);
            panicFirerate = NewpanicFirerate;
        }

    }
}
