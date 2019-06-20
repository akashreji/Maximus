using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

    public float thedistance;
    public GameObject actiondisplay;
    public GameObject actiontext;
    public GameObject thedoor;
	void Update () {
        thedistance = PlayerCasting.distancefromtarget;
	}
    void OnMouseOver()
    {   
      if(thedistance<=2)
        {
            actiondisplay.SetActive(true);
            actiontext.SetActive(true);
        }
      if(Input.GetButtonDown("Action"))
        {
            if(thedistance<=2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actiondisplay.SetActive(false);
                actiontext.SetActive(false);
                thedoor.GetComponent<Animation>().Play("dooranimation");
            }
        }
    }
    void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        actiontext.SetActive(false);
    }
}
