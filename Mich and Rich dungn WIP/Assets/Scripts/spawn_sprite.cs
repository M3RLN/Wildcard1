using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_sprite : MonoBehaviour {

    public void SpawnSprite(GameObject cubePrefab)
    {
        Vector3 main_cam_pos = Camera.main.transform.position;
        Vector3 spawn_location = new Vector3(main_cam_pos.x, main_cam_pos.y, 0);
        Instantiate(cubePrefab, spawn_location, Quaternion.identity);
	}
}
