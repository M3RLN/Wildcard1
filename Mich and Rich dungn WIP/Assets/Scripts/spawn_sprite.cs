using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_sprite : MonoBehaviour {

    public void SpawnSprite(GameObject cubePrefab)
    {
        GameObject spawn_sprite = Instantiate(cubePrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
		spawn_sprite.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
	}
}
