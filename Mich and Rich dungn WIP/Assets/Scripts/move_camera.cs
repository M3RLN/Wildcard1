using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour {

    public float edge_detection;
    public float speed;
    
    // Update is called once per frame
    void Update () {
        if (Input.mousePosition.x >= Screen.width - edge_detection) // move camera right
        {
            Vector3 new_camera_pos = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            transform.position = new_camera_pos;
        }
        if (Input.mousePosition.x <= edge_detection) // move camera left
        {
            Vector3 new_camera_pos = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
            transform.position = new_camera_pos;
        }
        if (Input.mousePosition.y <= edge_detection) // move camera up
        {
            Vector3 new_camera_pos = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
            transform.position = new_camera_pos;
        }
        if (Input.mousePosition.y >= Screen.height - edge_detection) // move camera down
        {
            Vector3 new_camera_pos = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
            transform.position = new_camera_pos;
        }
	}
}
