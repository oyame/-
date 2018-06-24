using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour {

    public prefabbox prefabbox;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            prefabbox.OnView(prefabbox.viewtype.LOAD);
        }
	}
}
