using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
	public GameObject cloudsLoop;
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}
	void OnBecameInvisible() {
		transform.Translate(80f, 0, 0);
	}
}
