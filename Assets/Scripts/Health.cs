using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Health : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;

    public int health;
    public Slider visualHealth;

    
    private void Update()
    {
        visualHealth.GetComponent<Slider>().value = health;

        if (health <= 0)
        {
            GameOverScreen.SetActive(true);
        }
    }

}

