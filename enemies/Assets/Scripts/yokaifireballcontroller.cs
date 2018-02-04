using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokaifireballcontroller : MonoBehaviour {


    public float destroyTime;
    public int dmg = 10;


    // Use this for initialization
    void Start() {
        Destroy(gameObject, destroyTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger != true && collision.CompareTag("enemy"))
        {
            collision.SendMessageUpwards("YokaiDamage", dmg);
            Destroy(gameObject);

        }
    }
}
