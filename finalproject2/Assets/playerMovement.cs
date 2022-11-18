using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    CharacterController controller;

    public float speed = 6f;
    public float gravity = 20f;
    public float jump = 8f;

    public int score = 0;
    Vector3 movedirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            movedirection = new Vector3(Input.GetAxis("Horizontal"), 0f,2); 
            movedirection *= speed;

            if (Input.GetButton("Jump"))
            {
                movedirection.y = jump;
            }
        }

        movedirection.y -= gravity * Time.deltaTime;
        controller.Move(movedirection * Time.deltaTime);
    }
}
