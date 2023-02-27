using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [Header("Player Values")]
    public float Speed;
    public float JumpSpeed;
    private Rigidbody2D playerRB2D;
    private Animator playerAnim;

    [Header("Ground Check")]
    public bool TouchingGround;
    public Transform PlayerFeet;
    public LayerMask GroundLayer;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
		playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get move input
        int moveXDirection = 0;

        if (Input.GetKey(KeyCode.D))
        {
        moveXDirection = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveXDirection = -1;
        }

        //Apply move input

        float horizontalSpeed = moveXDirection * Speed;
        playerRB2D.velocity = new Vector2(horizontalSpeed, playerRB2D.velocity.y);
        playerAnim.SetFloat("Speed", Mathf.Abs(horizontalSpeed));

        //Get jump input

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            //If on the ground, apply jump input
            if (TouchingGround)
            {
                playerRB2D.AddForce(JumpSpeed * Vector2.up, ForceMode2D.Impulse);
                TouchingGround = false;
            }
        }


        //Check if grounded
        GroundCheck();

        playerAnim.SetBool("IsGrounded", TouchingGround);
    }

    private void GroundCheck()
    {
        TouchingGround = Physics2D.OverlapCircle(PlayerFeet.position, 0.1f, GroundLayer);
    }
}
