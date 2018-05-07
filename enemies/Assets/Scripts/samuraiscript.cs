using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samuraiscript : MonoBehaviour
{
    public float moveSpeed = 0.75f;
    public int health = 50;

    private bool attacking = false;
    private float Cooldown = 0;
    private float moveSpeedContainer;

    public Collider2D attackTriggerSamurai;
    private Animator anim;

    private bool control = false;
    private bool nocollide = false;
    private bool facingleft = true;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attackTriggerSamurai.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("attacking", attacking);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (control == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (control)
        {
            attacking = false;
            attackTriggerSamurai.enabled = false;

            if (Input.GetKey(KeyCode.K))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-1.5f, GetComponent<Rigidbody2D>().velocity.y);
                if (facingleft == false)
                {
                    facingleft = true;
                    transform.Rotate(0, 180, 0);
                }
            }
            if (Input.GetKey(KeyCode.L))
            {

                GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, GetComponent<Rigidbody2D>().velocity.y);

                if (facingleft == true)
                {
                    facingleft = false;
                    transform.Rotate(0, 180, 0);
                }
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                attacking = true;
                attackTriggerSamurai.enabled = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (control == false && nocollide == false)
        {
            if (col.gameObject.tag == "wall" || col.gameObject.tag == "enemy")
            {
                transform.Rotate(0, 180, 0);
                moveSpeed *= -1;
                if (facingleft)
                {
                    facingleft = false;
                }
                else
                {
                    facingleft = true;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (control == false)
        {
            if (other.tag == "Player")
            {
                nocollide = true;
                attacking = true;
                attackTriggerSamurai.enabled = true;
                Cooldown -= Time.deltaTime;
                if (moveSpeed == 0.75f)
                {
                    moveSpeedContainer = 0.75f;
                }
                if (moveSpeed == -0.75f)
                {
                    moveSpeedContainer = -0.75f;
                }
                moveSpeed = 0f;
                if (Cooldown <= 0.2f)
                {
                    Cooldown = 1.25f;
                }
                else
                {
                    attacking = false;
                    attackTriggerSamurai.enabled = false;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (control == false)
        {
            if (other.tag == "Player")
            {
                moveSpeed = moveSpeedContainer;
                nocollide = false;
            }
        }
    }

    void OnMouseDown()
    {
        if (control)
        {
            control = false;
            if (facingleft)
            {
                moveSpeed = 1f;
            }
            if (facingleft == false)
            {
                moveSpeed = -1f;
            }
        }
        else
        {
            control = true;
        }
    }
    public void YokaiDamage(int damage)
    {
        health -= damage;
    }
}
