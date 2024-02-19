using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class P2Controller : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float vInput = 0;
        float hInput = 0;
   
        if (Input.GetKey(KeyCode.J))
        {
            hInput = -1;
            //transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.L))
        {
            hInput = 1;
            //transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.I))
        {
            vInput = 1;
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;

            if (Input.GetKey(KeyCode.K))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
