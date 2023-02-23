using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerTwoController : MonoBehaviour {
	public ParticleSystem dust;
	public ParticleSystem poof;

	[Header("Player Values")]
	private Rigidbody2D rb2D;
	private Animator playerAnim;
	private int direction;
	public float speed;
	public float jumpSpeed;

	[Header("Ground Check")]
	private bool isJumping;
	private bool isGrounded;
	public Transform feet;
	public float radius;
	public LayerMask groundMask;

	private void Awake() {
		rb2D = GetComponent<Rigidbody2D>();
		playerAnim = GetComponent<Animator>();
	}

	void Update() {
		direction = 0;
		isJumping = false;

		if (Input.GetKey(KeyCode.RightArrow)) {
			direction += 1;
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			direction -= 1;
		}

		if (Input.GetKey(KeyCode.UpArrow)) {
			isJumping= true;
		}
		
	}

	private void FixedUpdate() {
		float x = speed * direction;

		rb2D.velocity = new Vector2(x, rb2D.velocity.y);
		playerAnim.SetFloat("Speed", Mathf.Abs(x));
		if (direction != 0 && isGrounded) {
			CreateDust();
		}

		GroundCheck();

		if (isJumping) {
			if (isGrounded) {
				rb2D.AddForce(jumpSpeed * Vector2.up, ForceMode2D.Impulse);
				isGrounded = false;				
			}
		}

		
		playerAnim.SetBool("IsGrounded", isGrounded);

	}

	private void GroundCheck() {
		bool isNotInAir = isGrounded;
		isGrounded = Physics2D.OverlapCircle(feet.position, radius, groundMask);
		if (!isNotInAir && isGrounded) {
			CreatePoof();
		}
	}
	
	private void CreateDust() {
		dust.Play();
	}

	private void CreatePoof() {
		poof.Play();
	}

}