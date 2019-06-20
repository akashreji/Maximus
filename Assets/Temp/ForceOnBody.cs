using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForceOnBody : MonoBehaviour {
    public Rigidbody rb;
    
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
    
    // Update is called once per frame
    public float forceAmount;
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Action"), Input.GetAxis("Vertical"));
        rb.AddForce(move*forceAmount);
    }
}
