using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {
	private Player player;
	void Start()
	{
		player = gameObject.GetComponentInParent<Player>();
	}

	void OnCollisionEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "player")
		{ player.grounded = true; }
		print("OnCollisionEnter2D");
	}
	void OnCollisionStay(Collider2D col)
	{
		player.grounded = true;
		print("OnCollisionEnter2D");
	}

	void OnCollisionExit2D(Collider2D col)
	{
		player.grounded = false;
		print("OnCollisionEnter2D");
	}
	//void OnTriggerEnter2D(Collider2D col)
	//{
	//	player.grounded = true;
	//}
	//void OnTriggerStay(Collider2D col)
	//{
	//	player.grounded = true; 
	//}

	//void OnTriggerExit2D(Collider2D col)
	//{
	//	player.grounded = false;
	//}
}
