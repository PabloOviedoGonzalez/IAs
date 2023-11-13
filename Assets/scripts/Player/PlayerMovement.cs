using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vel = 30f;
    public float gravityForce = -9.81f; //fuerza de la gravedad para este obj
    public float jumpForce = 20f; //fuerza de salto
    private float playerYVelocity; //velocidad en y del player
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 movementVector = transform.forward * vel * z + transform.right * vel * x + transform.up * gravityForce; //le da velocidad a cada vector

        playerYVelocity += gravityForce;

        if (Input.GetKey(KeyCode.Space) && controller.isGrounded) //salto, dando a la tecla space y si el "contrller" est? en el suelo
        {
            playerYVelocity = jumpForce;
        }
        movementVector += transform.up * playerYVelocity;

        controller.Move(movementVector * Time.deltaTime); //libre de framerate
    }
}


