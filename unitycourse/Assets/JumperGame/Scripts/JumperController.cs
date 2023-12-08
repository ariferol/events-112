using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperController : MonoBehaviour
{
    public float jumpSpeed = 5;
    public float gravityMultiplier;
    private Rigidbody rb;
    private Animator jumperAnim;
    public ParticleSystem particle;

    public bool gameOver = false;


    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
        jumperAnim = GetComponent<Animator>();
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            jumperAnim.SetTrigger("Jump_trig");
            //isOnGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            gameOver = true;
            jumperAnim.SetBool("Death_b", true);
            particle.Play();
            //jumperAnim.SetInteger("DeathType_int", 2);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
