using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D rigid;
	public float jumpSpeed;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask ground;
	public bool grounded;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, ground); 
			
		if (Input.GetAxisRaw ("Horizontal") > 0f) 
		{
			rigid.velocity = new Vector3 (moveSpeed, rigid.velocity.y, 0f);
		} 
		else if (Input.GetAxisRaw ("Horizontal") < 0f) {
			rigid.velocity = new Vector3 (-moveSpeed, rigid.velocity.y, 0f);
		} 
		else 
		{
			rigid.velocity = new Vector3 (0f, rigid.velocity.y, 0f);
		}
		if (Input.GetButtonDown("Jump"))
		{
			rigid.velocity = new Vector3 (rigid.velocity.x, jumpSpeed, 0f);
		}

	}
}