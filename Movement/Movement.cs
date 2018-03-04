using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float vert = speed * Input.GetAxis("Vertical");
        float hori = speed * Input.GetAxis("Horizontal");

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        Vector3 movement = (forward * vert) + (right * hori);

        movement = movement * speed;

        Vector3 new_vel = new Vector3(movement.x, rb.velocity.y, movement.z);
        rb.velocity = new_vel;

    }
}
