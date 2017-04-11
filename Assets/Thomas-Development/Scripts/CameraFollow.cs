using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject followObject;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - followObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        transform.position = followObject.transform.position + offset;
    }
}
