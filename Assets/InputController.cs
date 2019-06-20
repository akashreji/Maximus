using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputController : MonoBehaviour
{
    public GameObject actiontext;

    private void Start()
    {
        
    }
    private void Update()
    {
        
        if (Input.GetButtonDown("Shoot"))
        {
            actiontext.SetActive(true);
        }
    }

}


