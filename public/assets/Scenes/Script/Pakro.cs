using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pakro : MonoBehaviour {

	public Transform enemy,player;
	float speed = 1f;
	// Use this for initialization
	void Start () {
		//player = GetComponent<Transform>();
		//enemy = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		enemy.position = Vector2.MoveTowards(enemy.position, player.position, speed * Time.deltaTime);
		//enemy.position = Vector3.Lerp(enemy.position, player.position, speed * Time.deltaTime);
	}
}
