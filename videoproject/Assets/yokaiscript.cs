using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokaiscript : MonoBehaviour
{
    public float velocity = 1f;
    public int health = 15;

    public Transform sightStart;
    public Transform sightEnd;
    public bool colliding;
    public LayerMask detectstuff;

    public GameObject fireball;
    public float speed;
    public float delay;




    // Use this for initialization
    void Start() {
        StartCoroutine(ShootsFire());
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, GetComponent<Rigidbody2D>().velocity.y);

        colliding = Physics2D.Linecast(sightStart.position, sightEnd.position, detectstuff);

        if (colliding)
        {
            transform.Rotate(0, 180, 0);
            velocity *= -1;
        }

    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            transform.Rotate(0, 180, 0);
            velocity *= -1;
        }
    }
    */
    void OnBecameInvisible()
    {

        enabled = false;
        Destroy(gameObject);

    }
    IEnumerator ShootsFire()

    {

        while (true)
        {


            yield return new WaitForSeconds(delay);
            GameObject clone = (GameObject)Instantiate(fireball, transform.position, transform.rotation);

            clone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;


        }


    }
}
