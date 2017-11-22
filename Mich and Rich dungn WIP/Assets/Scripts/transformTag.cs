using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformTag : MonoBehaviour {
	
	public void Button_Click() {
        GameObject[] playables = GameObject.FindGameObjectsWithTag("playable");
        foreach (GameObject instantiation in playables)
            instantiation.transform.tag = "unplayable";
	}
}
