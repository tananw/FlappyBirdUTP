using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
	public float speed = 2;
	public float tapForce = 300;
    public GameObject target;

	public UnityEngine.UI.Text text;
	// Start is called before the first frame update
	void Start() {
        Time.timeScale = 0;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            if(target != null)
            {
                Destroy(target);
            }
            Time.timeScale = 1;
            text.gameObject.SetActive(false);
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * tapForce);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
