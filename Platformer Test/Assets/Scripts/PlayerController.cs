using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    Animator theanimator;
    public bool isMoving;
    public bool isJumping;
    public bool isAttacking;

    // Use this for initialization
    void Start () {
        //theanimator = gameObject.GetComponent<Animator>();
        theanimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        isMoving = false;
        isJumping = false;
        isAttacking = false;

        if (GetComponent<Rigidbody2D>().velocity.x != 0)
            isMoving = true;
        else
            isMoving = false;
        

        if (GetComponent<Rigidbody2D>().velocity.y > 0)
            isJumping = true;
        else
            isJumping = false;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isAttacking = true;
        }

        theanimator.SetBool("mve", isMoving);
        theanimator.SetBool("jmp", isJumping);
        theanimator.SetBool("atk", isAttacking);

		if(Input.GetKeyDown (KeyCode.W))
        {
            if (GetComponent<Rigidbody2D>().velocity.y == 0)
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

