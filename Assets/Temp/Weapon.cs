using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {
    
    public Text bagcontents;
    public string objectName;
    public GameObject gunname;
    public Text shoottext;
  //  public GameObject info;

    // Use this for initialization
    void Start () {
		
	}
	// Update is called once per frame
	
    public virtual void inhand()
    {
        Debug.Log("Reached weapon stage");
        objectName = this.gameObject.name;
        gunname.gameObject.SetActive(true);
        //this.gameObject.SetActive(false);
        shoottext.text = "Shooting with" + objectName;
        bagcontents.text = "Equipped:" + objectName;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            shoottext.gameObject.SetActive(true);
            bagcontents.gameObject.SetActive(true);
            gunname.gameObject.SetActive(false);
        }
        else
            shoottext.gameObject.SetActive(false);
          
    }
    private void OnTriggerExit(Collider col)
    {
        gunname.gameObject.SetActive(false);
        shoottext.gameObject.SetActive(false);
    }

}
