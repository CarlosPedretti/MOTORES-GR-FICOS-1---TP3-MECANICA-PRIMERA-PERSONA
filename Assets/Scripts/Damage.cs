using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;
    public GameObject PLAYER;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PLAYER.GetComponent<Health>().health -= damage;
        }

        if (other.tag == "Enemy")
        {
            Debug.Log("Esto es un enemigo..");
        }
    }

}
