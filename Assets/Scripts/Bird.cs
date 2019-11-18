using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	public float speed = 2;
	public float tapForce = 300;
	// Start is called before the first frame update
	void Start() {
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * tapForce);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		Application.LoadLevel(Application.loadedLevel);
	}
}
