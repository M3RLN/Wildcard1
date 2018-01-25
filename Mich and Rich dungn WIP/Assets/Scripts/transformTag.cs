using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformTag : MonoBehaviour {

    public spawn_sprite target_script;
    

	public void Button_Click() {
        GameObject[] playables = GameObject.FindGameObjectsWithTag("playable");
        foreach (GameObject instantiation in playables)
            instantiation.transform.tag = "unplayable";

        target_script.max_one_room = false;
	}
}
