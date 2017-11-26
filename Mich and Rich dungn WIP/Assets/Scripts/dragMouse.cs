using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragMouse : MonoBehaviour {
    
    float distance = 50;

    private void OnMouseDrag()
    {
		if (transform.tag == "playable")
		{
			Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = objPosition;
		}
    }
	
    /*
	private void OnMouseOver () {
		if (transform.tag == "playable")
		{
			if (Input.GetMouseButton(1)) {
				print("Right Mouse Clicked");
				Destroy(gameObject);
			}
		}
	}
    */
}

