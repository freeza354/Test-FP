using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float PlayerMoveSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 3f;

		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);

		if (Input.GetKeyDown (KeyCode.Space)) {
			
			rb.AddForce (transform.forward * PlayerMoveSpeed);		
		
		}

	}
}
