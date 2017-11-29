using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    Animator theanimator;
    public bool isMoving;
    public bool isJumping;


    // Use this for initialization
    void Start () {
        //theanimator = gameObject.GetComponent<Animator>();
        theanimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        isMoving = false;
        isJumping = false;

        if (GetComponent<Rigidbody2D>().velocity.x != 0)
            isMoving = true;
        else
            isMoving = false;
        


        if (GetComponent<Rigidbody2D>().velocity.y > 0)
            isJumping = true;
        else
            isJumping = false;
        

        theanimator.SetBool("mve", isMoving);
        theanimator.SetBool("jmp", isJumping);

		if(Input.GetKeyDown (KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
    
}

