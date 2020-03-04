using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;
    public float speed;
    private bool facingRight = true;
    public float jumpForce;
    public bool isJumping;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime * speed,0f,0f);

        Flip(horizontal);


        if(Input.GetButtonDown("Jump") && rigidBody.velocity.y < 0.01f && rigidBody.velocity.y > -0.01f){
            rigidBody.AddRelativeForce(new Vector2(0f, jumpForce));

        }

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        animator.SetFloat("Jump", Mathf.Abs(rigidBody.velocity.y));
         
    }

    private void Flip(float horizontal){
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight){
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

}
