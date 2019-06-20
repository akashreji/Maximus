using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellClose : MonoBehaviour
{

    public float thedistance;
    public GameObject actiondisplay;
    public GameObject actiontext;
    public GameObject thedoor;
    void Update()
    {
        thedistance = PlayerCasting.distancefromtarget;
    }
    void OnMouseOver()
    {
        if (thedistance <= 2)
        {
            actiondisplay.SetActive(true);
            actiontext.SetActive(true);
           
        }
        
        if (Input.GetButtonDown("Close"))
        {
            if (thedistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = true;
                actiondisplay.SetActive(false);
                actiontext.SetActive(false);
                thedoor.GetComponent<Animation>().Play("Doorclose");
            }
        }
    }
    void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        actiontext.SetActive(false);
    }
}
