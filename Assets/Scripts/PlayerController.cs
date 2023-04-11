using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    //private Rigidbody rb;
    public float JomForce;
    private CharacterController controller;
    private Vector3 moveDirection;

    public float GravityScale;
    // Start is called before the first frame update

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() 
    {
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal")*MoveSpeed, rb.velocity.y, Input.GetAxis("Vertical")*MoveSpeed);
        //if(Input.GetButtonDown("Jump")) 
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, JomForce, rb.velocity.z);
        //}

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, moveDirection.y, Input.GetAxis("Vertical") * MoveSpeed);

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump")) {
                moveDirection.y = JomForce;
            }
        }
        moveDirection.y += Physics.gravity.y*GravityScale * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);



    }
}
