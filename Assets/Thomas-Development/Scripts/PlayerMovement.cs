using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D playerRB;
    public float moveSpeed;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate()
    {
        // Moving the player
        float moveVertical;
        float movehorizontal;
        Vector3 moveDirection;

        moveVertical = Input.GetAxis("Vertical");
        movehorizontal = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(movehorizontal, moveVertical, 0.0f).normalized;

        playerRB.velocity = moveDirection * moveSpeed;

        // Rotating the player
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        mousePositionVector3 = Camera.main.ScreenToWorldPoint(mousePositionVector3);

        Vector3 targetdir = mousePositionVector3 - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetdir);
    }
}
