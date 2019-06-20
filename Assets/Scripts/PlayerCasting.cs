using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {

    public static float distancefromtarget;
    public float totarget;
	void Update () {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit))
        {
            totarget = hit.distance;
            distancefromtarget = totarget;
        }
	}
}
