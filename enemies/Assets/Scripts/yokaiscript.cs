using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokaiscript : MonoBehaviour
{
    public float moveSpeed = 1f;
    public int health = 15;


    public GameObject fireball;
    public float speed;
    public float delay;




    // Use this for initialization

    void Awake() {
        StartCoroutine(ShootsFire());
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);


        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "wall")
        {
            transform.Rotate(0, 180, 0);
            moveSpeed *= -1;
        }
        if (col.gameObject.tag == "enemy")
        {
            transform.Rotate(0, 180, 0);
            moveSpeed *= -1;
        }
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
    public void SamuraiDamage(int damage)
    {
        health -= damage;
    }
    public void YokaiDamage(int damage)
    {
        health -= damage;
    }
    public void OniDamage(int damage)
    {
        health -= damage;
    }
}
