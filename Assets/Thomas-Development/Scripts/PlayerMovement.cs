using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D playerRB;
    public Camera cam;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Moving the player
        float moveVertical;
        float movehorizontal;

        moveVertical = Input.GetAxis("Vertical");
        movehorizontal = Input.GetAxis("Horizontal");

        playerRB.velocity = new Vector3(movehorizontal, moveVertical);

        // Rotating the player
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        mousePositionVector3 = Camera.main.ScreenToWorldPoint(mousePositionVector3);

        Vector3 targetdir = mousePositionVector3 - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetdir);
    }
}
