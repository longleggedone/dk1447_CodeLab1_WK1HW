using UnityEngine;
using System.Collections;

public class BulletMoveScript : MonoBehaviour {

	public float velocity = 600f;

	public Vector3 currentVel;
	public float bumpForce = 10f;


	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		bumpForce = 6f;
		rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce(Vector3.up * velocity);
	}

    void FixedUpdate(){
		currentVel = rb.velocity;
	}


	public void OnCollisionEnter(Collision other) {
		rb.AddForce(other.contacts[0].normal*bumpForce, ForceMode.Impulse);
	}
}
