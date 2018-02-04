using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAttackScript : MonoBehaviour {

    public int dmg = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.isTrigger != true && collision.CompareTag("Player"))
        {
            collision.SendMessageUpwards("SamuraiDamage", dmg);
        }
    }
}
