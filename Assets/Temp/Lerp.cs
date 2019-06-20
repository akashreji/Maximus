using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Vector3 startpos;
    public Vector3 endpos;
    public float position;
    public float magnitude;
    public GameObject cube;
    //[Range(0f, 1f)]
    public float demo;
    public float findslope;
   
    // Use this for initialization
    void Start()
    {
        findslope = (startpos.x - endpos.x) / (startpos.y - endpos.y);
        Debug.Log(findslope);
        Debug.Log(startpos);
        startpos.Normalize();
        magnitude=startpos.magnitude;
      
        cube = this.gameObject;
        cube.transform.position = startpos;
    }
    public void slide(float value)
    {

        Debug.Log(value);
        if(value<0)
        cube.transform.Translate(0f, 0f,value);
       
        else
            if(value>0)
            cube.transform.Translate(0f, 0f, value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
