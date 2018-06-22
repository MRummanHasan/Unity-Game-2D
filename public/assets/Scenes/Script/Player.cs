using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150f;
    public bool grounded;

    private Rigidbody2D rd2d;
    private Animator anim;

	void Start ()
    {
        rd2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
	}
	
	
	void Update ()
    {
        //anim.SetBool("Grounded",grounded);
		//anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
		//anim.SetFloat("Speed", Mathf.Abs(rd2d.velocity.x));

		if (Input.GetAxis("Horizontal") < -0.1f)
		{
			transform.localScale = new Vector3(-1, 1, 1);
		}
		if (Input.GetAxis("Horizontal") > 0.1f)
		{
			transform.localScale = new Vector3(1, 1, 1);
		}
		if ((Input.GetButtonDown("Jump")) && true)
		{
			rd2d.AddForce(Vector2.up * jumpPower);
		}
	}

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        //moving the player
        rd2d.AddForce((Vector2.right * speed) * h);

        // limiting the speed of player
        if (rd2d.velocity.x > maxSpeed)
        {
            rd2d.velocity = new Vector2(maxSpeed, rd2d.velocity.y);
        }
        if (rd2d.velocity.x < -maxSpeed)
        {
            rd2d.velocity = new Vector2(-maxSpeed, rd2d.velocity.y);
        }

    }

}
