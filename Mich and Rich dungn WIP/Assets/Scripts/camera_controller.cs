using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour {

    public float edge_detection;
    public float speed;

    private void pan_camera()
    {
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

    private void delete_instantiation()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

            if (hit.collider != null)
            {
                Transform objectHit = hit.transform;
                if (objectHit.tag == "playable")
                    Destroy(objectHit.gameObject);
            }

            /*
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null)
            {
                Transform objectHit = hit.transform;
                if (objectHit.tag == "playable")
                    Destroy(objectHit.gameObject);
            }
            */
        }
    }
    
    // Update is called once per frame
    void Update () {
        pan_camera();
        delete_instantiation();
    }
}
