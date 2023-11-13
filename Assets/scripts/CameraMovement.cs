using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float mouseSens = 2.0f; //sensibilidad raton
    private float verticalRatotion = 0;
    //private float horizontalRotation = 0; para movimiento en torreta
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //ocultar el cursor de mover la camara
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens;  // horizontal
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens; // vertical, asentir

        verticalRatotion -= mouseY;
        //horizontalRotation += mouseX;

        transform.localEulerAngles = Vector3.right * verticalRatotion; // movimiento cabeza vertical
        //transform.localEulerAngles = Vector3.right * verticalRatotion + Vector3.up * horizontalRotation;  movimiento en torreta
        playerTransform.Rotate(Vector3.up * mouseX); //para el movimiento de la vista horizontal giramos todo el personaje


    }
}
