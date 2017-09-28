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
	private int airJump;
	public int jumpLimit;
	public Vector3 respawn;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		playerScale = gameObject.transform.localScale.y;
		anim = GetComponent<Animator> ();
		respawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, ground); 
		if (Input.GetAxisRaw ("Horizontal") > 0f) 
		{
			rigid.velocity = new Vector3 (moveSpeed, rigid.velocity.y, 0f);
			transform.localScale = new Vector3(playerScale,playerScale,playerScale);
		} 
		else if (Input.GetAxisRaw ("Horizontal") < 0f) {
			rigid.velocity = new Vector3 (-moveSpeed, rigid.velocity.y, 0f);
			transform.localScale = new Vector3(-playerScale,playerScale,playerScale);
		} 
		else 
		{
			rigid.velocity = new Vector3 (0f, rigid.velocity.y, 0f);
		}
		if (Input.GetButtonDown("Jump") && (airJump + 1 < jumpLimit))
		{
			rigid.velocity = new Vector3 (rigid.velocity.x, jumpSpeed, 0f);
			airJump = airJump + 1;
		}
		if (grounded)
		{
			airJump = 0;
		}
		anim.SetFloat ("Speed", Mathf.Abs (rigid.velocity.x));
		anim.SetBool ("Grounded", grounded);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "KillPlane")
			{
			gameObject.transform.position = respawn;
			}
		if(other.tag == "Checkpoint")
		{
			respawn = other.transform.position;
		}
	}
}