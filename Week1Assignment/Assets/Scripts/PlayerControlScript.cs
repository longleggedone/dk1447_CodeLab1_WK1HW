using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {
	
	public GameObject enemyPlayer;

	public float speed = 1;

	public float distance;

	public KeyCode upKey = KeyCode.W;
	public KeyCode downKey = KeyCode.S;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;

	// Use this for initialization
	void Start () {
		distance = Vector3.Distance(transform.position, enemyPlayer.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		Move(Vector3.up, upKey);
		Move(Vector3.down, downKey);
		Move(Vector3.left, leftKey);
		Move(Vector3.right, rightKey);

		if(enemyPlayer != null){
		distance = Vector3.Distance(transform.position, enemyPlayer.transform.position);
		}
		if(distance > 5){
			transform.localScale = new Vector3(distance/5, distance/5, distance/5);
		}
	}

	void Move(Vector3 dir, KeyCode key){
		if(Input.GetKey(key)){
			transform.Translate(dir * speed * Time.deltaTime);
		}
	}

}
