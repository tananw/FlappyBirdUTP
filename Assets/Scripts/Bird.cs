using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
	public float tapForce = 300;
	public bool isDead = false;
	public AudioSource jumpSound, bumpSound;
    private Rigidbody2D rigid2D;
    private int screenHeight = Screen.height;

    void Start() {
		Time.timeScale = 0;
        rigid2D = GetComponent<Rigidbody2D>();
    }
        
	void Update() {
		if (!isDead) {
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				jumpSound.Play();
                Time.timeScale = 1;
                rigid2D.velocity = Vector2.zero;
                rigid2D.AddForce(Vector2.up * tapForce);
                if(rigid2D.position.y >= 4.5f)
                {
                    rigid2D.AddForce(Vector2.up * -tapForce);
                }
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
        if (!isDead)
        {
            GetComponent<Animator>().enabled = false;
            transform.Rotate(Vector3.forward * -180);
        }
        rigid2D.velocity = Vector2.zero;
        isDead = true;
		bumpSound.Play();
        Controller.instance.playerDied();
	}
}

