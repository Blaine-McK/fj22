using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public GameObject otherPlayer;
    private string thisPlayer;

    float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    private void Start()
    {
        thisPlayer = this.name.ToString();
        Debug.Log(thisPlayer);
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
