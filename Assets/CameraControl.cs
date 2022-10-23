using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public bool activeTP;

    public Transform posTP;
    public Transform posPP;

    //Camara TP
    public float rotSpeed;
    public float rotMin, rotMax;
    float mouseX, mouseY;
    public Transform CameraTarget, player;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Cam()
    {
        mouseX += rotSpeed * Input.GetAxis("Mouse X");
        mouseY -= rotSpeed * Input.GetAxis("Mouse Y");
        mouseY = Mathf.Clamp(mouseY, rotMin, rotMax);

        player.rotation = Quaternion.Euler(0.0f, mouseX, 0.0f);
    }


    void LateUpdate()
    {

        Cam();

        if (activeTP == false && Input.GetKeyDown(KeyCode.H))
        {
            activeTP = true;
            transform.position = posPP.position;
        }
        else if (activeTP == true && Input.GetKeyDown(KeyCode.H))
        {
            activeTP = false;
            transform.position = posTP.position;
            transform.LookAt(player);
        }

    }
}