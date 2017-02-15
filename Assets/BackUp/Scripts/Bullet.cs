using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    Rigidbody2D ridgid;
    float deSpawn = .4f;

	// Use this for initialization
	void Start () {
        ridgid = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate() {

        deSpawn -= Time.deltaTime;

        if (deSpawn <= 0)
        {
            Destroy(this.gameObject);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        { 
            ridgid.velocity = transform.TransformDirection(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ridgid.velocity = transform.TransformDirection(Vector2.down * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ridgid.velocity = transform.TransformVector(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ridgid.velocity = transform.TransformDirection(Vector2.left * speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
