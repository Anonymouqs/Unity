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
	private float playerScale;
	private Animator anim;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		playerScale = gameObject.transform.localScale.y;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, ground); 
		print (grounded);
		if (Input.GetAxisRaw ("Horizontal") > 0f) 
		{
			rigid.velocity = new Vector3 (moveSpeed, rigid.velocity.y, 0f);
			transform.localScale = new Vector3(playerScale,playerScale,playerScale);
			print("Player.Move.Right");
		} 
		else if (Input.GetAxisRaw ("Horizontal") < 0f) {
			rigid.velocity = new Vector3 (-moveSpeed, rigid.velocity.y, 0f);
			transform.localScale = new Vector3(-playerScale,playerScale,playerScale);
			print("Player.Move.Left");
		} 
		else 
		{
			rigid.velocity = new Vector3 (0f, rigid.velocity.y, 0f);
		}
		if (Input.GetButtonDown("Jump") && grounded)
		{
			rigid.velocity = new Vector3 (rigid.velocity.x, jumpSpeed, 0f);
			print("Player.Move.Jump");
		}
		anim.SetFloat ("Speed", Mathf.Abs (rigid.velocity.x));
		anim.SetBool ("Grounded", grounded);

	}
}