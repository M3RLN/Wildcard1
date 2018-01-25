using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_controller : MonoBehaviour {

    private float distance = 50;
    private float doubleClickStart = 0;
    private int count = 0;


    private void OnMouseDrag()
    {
		if (transform.tag == "playable")
		{
			Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = objPosition;
		}
    }


    private void OnMouseUp()
    {
        if ((Time.time - doubleClickStart) < 0.3f)
        {
            this.onDoubleClick();
            doubleClickStart = -1;
        }
        else
            doubleClickStart = Time.time;
    }
    private void onDoubleClick()
    {
        // goes into a particular room and change its contents
        //   - transition into a scene
        //       - if no previously saved state, load "standard" scene data
        //       - else load previously saved state

        // Application.LoadLevel("createRoom scene");

        UnityEngine.SceneManagement.SceneManager.LoadScene("createRoom scene");

        Debug.Log("DOUBLE CLICKED");
        Debug.Log(UnityEngine.SceneManagement.SceneManager.sceneCount);
        // Debug.Log(++count);
    }
}

