using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    public float jump = 100f;
    public float jump2 = 500f;
    public Animator animator;
    int jumpCount = 0;
    Rigidbody2D rigid;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {

            animator.SetBool("jump", true);

            if (jumpCount == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                jumpCount += 1;
            }
            else if (jumpCount == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                jumpCount += 1;
            }
        }
    }

    private void FixedUpdate()
    {
        if (rigid.velocity.y < -2.27)
        animator.SetBool("jump", false);
             
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
            jumpCount = 0;
    }

}
