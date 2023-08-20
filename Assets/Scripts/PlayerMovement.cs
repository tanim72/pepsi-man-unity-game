using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40;

    float horizontalMove = 0;
    bool jump = false;
    public bool crouch = false;
    Animator m_animator;
    private void Start()
    {
        m_animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            m_animator.SetBool("isJump", true);
            m_animator.SetBool("isCrouch", false);
            m_animator.SetBool("isRunning", false);


        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            m_animator.SetBool("isRunning", true);
            m_animator.SetBool("isJump", false);
            m_animator.SetBool("isCrouch", false);


        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            m_animator.SetBool("isRunning", true);
            m_animator.SetBool("isJump", false);
            m_animator.SetBool("isCrouch", false);



        }
        else if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            m_animator.SetBool("isCrouch", true);
            m_animator.SetBool("isJump", false);
            m_animator.SetBool("isRunning", false);


        }
        
        else {
            m_animator.SetBool("isRunning", false);
            m_animator.SetBool("isCrouch", false);
            m_animator.SetBool("isJump", false);

        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;


        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;

        }
      
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("fire");
        }

        if (transform.position.y < -10)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
}
