using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeEditor : MonoBehaviour {
	float distance = 10;
    private bool dragging = false;
	private bool deleting = false;

    private void OnMouseDown()
    {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = objPosition;
			dragging = true;
		}
		else if (Input.GetMouseButtonDown(1)) {
			deleting = true;
		}
	}

    private void OnMouseUp()
    {
        dragging = false;
		deleting = false;
    }

    private void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
        /*
		if (deleting) {
			Destroy(gameObject);
		}
		
		if (Input.GetMouseButtonDown(1)){
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, hit)){
				Destroy(hit.transform.gameObject);
			}
		}
        */
        /*
		if (Input.GetMouseButtonDown(1)) {
			print("Right Mouse Clicked");
			Destroy(gameObject);
		}
	    */
    }

    /*
    private void OnMouseOver () {
		if (Input.GetMouseButton(1)) {
			print("Right Mouse Clicked");
			Destroy(gameObject);
		}
	}
    */
}
