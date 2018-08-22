using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDeinit : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(DestroyCannon());
    }

    
    IEnumerator DestroyCannon()
    {
        yield return new WaitForSeconds(1);
        DestroyObject(gameObject);
    }
}
