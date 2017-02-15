using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    Rigidbody rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();		
	}
	
	// Update is called once per frame
	void Update () {
        rigid.velocity = transform.TransformDirection(Vector2.up * speed);
	}
}
