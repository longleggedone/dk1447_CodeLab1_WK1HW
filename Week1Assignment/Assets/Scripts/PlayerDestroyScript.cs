using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision other){
		Destroy(gameObject);
	}

	public void OnCollisionExit(Collision other){
		Destroy(gameObject);
	}
}
