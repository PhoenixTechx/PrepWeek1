using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
    
    //Variables
    public float Damage = 1;
    public float MoveSpeed = 1;
    public float MaxPlayerSpeed = 30;
    public Rigidbody2D PlayerRB;
    public Gun gun;


	// Use this for initialization
	void Start () {
        //Finds the Rigidbody2D attached to this object
        PlayerRB = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        // Checks if the player is moving on a horizontal axis
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Checks if the player is moving on a vertical axis
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 Movement = new Vector2(moveHorizontal, moveVertical);
        PlayerRB.AddForce(Movement * MoveSpeed);

        if (PlayerRB.velocity.magnitude > MaxPlayerSpeed)
        {
            PlayerRB.velocity = PlayerRB.velocity.normalized * MaxPlayerSpeed;
        }

        // Hults the players momentum
        if (Input.GetKeyDown(KeyCode.Space)) {
            PlayerRB.Sleep();
        }
       
    }
}
