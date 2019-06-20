using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    private void OnTriggerEnter(Collider other)
    {

        other.gameObject.GetComponent<enemybase>().Kill(gameObject);
       // other.gameObject.GetComponent<enemy1>().Attack();



    }


}
