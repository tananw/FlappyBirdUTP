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
	public AudioSource jumpSound, bumpSound;
    private Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start() {
		Time.timeScale = 0;
        rigid2D = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
        
	// Update is called once per frame
	void Update() {
		if (!isDead) {
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				jumpSound.Play();
                rigid2D.velocity = Vector2.zero;
				Time.timeScale = 1;
				rigid2D.AddForce(Vector2.up * tapForce);
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

