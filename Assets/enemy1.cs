using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1: enemybase {


    // Use this for initialization
    
  /*  void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag=="player")
        {
            Destroy(c.gameObject);
        }
    }*/
  

    void Start()
    {
       
    }
  
    // Update is called once per frame
    void Update () {
		
	}

    public void Attack() {
    }


    public override void Kill(GameObject obj)
    {


       // base.Kill();

        print("Im enemy1");

    }
}

