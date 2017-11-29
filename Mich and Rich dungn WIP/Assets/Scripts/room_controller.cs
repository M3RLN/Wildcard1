using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_controller : MonoBehaviour {
    
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
}

