using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoCamara : MonoBehaviour
{

    //CameraControl

    public bool activeTP;

    public Transform posTP;
    public Transform posPP;

    public Transform CameraTarget, player;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Cam()
    {

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


