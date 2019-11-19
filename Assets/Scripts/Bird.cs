using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
	public float speed = 2;
	public float tapForce = 300;
	public bool isDead = false;
	public GameObject target;
	public AudioSource jumpSound, bumpSound;

	// Start is called before the first frame update
	void Start() {
		Time.timeScale = 0;
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

	// Update is called once per frame
	void Update() {
		if (!isDead) {
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				jumpSound.Play();
				Time.timeScale = 1;
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * tapForce);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		isDead = true;
		bumpSound.Play();
        Controller.instance.playerDied();
	}
}

