using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

	public AudioSource scoreSound;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.GetComponent<Bird>() != null) {
			Controller.instance.BirdScored();
			scoreSound.Play();
		}
	}
}
