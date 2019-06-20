using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f,0f, Input.GetAxis("Vertical")*Time.deltaTime*3);
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal")*Time.deltaTime*100, 0));
        
    }
}
