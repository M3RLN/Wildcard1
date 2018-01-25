using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAll : MonoBehaviour {

	public void DestroyGameObjectsWithTag(string tag)
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
		foreach (GameObject target in gameObjects) {
			Destroy(target);
		}
	}
}
