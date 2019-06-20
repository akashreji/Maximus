using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuberotate : MonoBehaviour {
    Animator cubeanim;
	// Use this for initialization
	void Start () {
        cubeanim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void rotatex()
    {
        bool xrotate = true;
        bool yrotate = false;
        cubeanim.SetBool("xaxisrotate", xrotate);
        cubeanim.SetBool("yaxisrotate", yrotate);   
    }
    public void rotatey()
    {
        bool yrotate = true;
        bool xrotate = false;
        cubeanim.SetBool("yaxisrotate", yrotate);
        cubeanim.SetBool("xaxisrotate", xrotate);
    }
}
