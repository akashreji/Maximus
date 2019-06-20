using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pistol : Weapon
{
    public Text pistoltext;
    
   
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    public override void inhand()
    {
        Debug.Log("Before Base calling");
        base.inhand();
    }
   
    void Update()
    {
       
        
    }
    

   
}
