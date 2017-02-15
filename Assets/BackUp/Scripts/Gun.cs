using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bullet;
    public float speed;

	// Use this for initialization
	void Start () {

        bullet.GetComponent<Bullet>().speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }

    }

}
