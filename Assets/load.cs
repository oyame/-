using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour {

    public prefabbox prefabbox;
    bool unko = false;

    // Use this for initialization
    void Update () {
        if(unko == false && fadedesuwa.Instance.is_Fading() == false)
        {
            unko = true;
            Invoke("next", 2f);
        }
        
	}

    void next()
    {
        prefabbox.OnView(prefabbox.viewtype.HOME);
    }
	
}
