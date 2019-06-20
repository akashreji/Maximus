using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour {

    public int lightmode;
    public GameObject flamelight;
	
	
	// Update is called once per frame
	void Update () {
	if(lightmode==0)
        {
            StartCoroutine(AnimateLight());
        }
	}
    IEnumerator AnimateLight()
    {
        lightmode = Random.Range(1, 3);
        if (lightmode == 1)
            flamelight.GetComponent<Animation>().Play("torchanimation");
        if (lightmode == 2)
            flamelight.GetComponent<Animation>().Play("torchanimation2");
        yield return new WaitForSeconds(1f);
        lightmode = 0;
    }
}
