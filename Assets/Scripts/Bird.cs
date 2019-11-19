using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
	public float speed = 2;
	public float tapForce = 300;
	public bool gameOver = false;
	public GameObject target;
	public AudioSource jumpSound, bumpSound;

	public Text text;
	// Start is called before the first frame update
	void Start() {
		Time.timeScale = 0;
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

	// Update is called once per frame
	void Update() {
		if (!gameOver) {
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				jumpSound.Play();
				if (target != null) {
					Destroy(target);
				}
				Time.timeScale = 1;
				text.gameObject.SetActive(false);
				GetComponent<Rigidbody2D>().AddForce(Vector2.up * tapForce);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		gameOver = true;
		bumpSound.Play();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}

