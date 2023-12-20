using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberDuck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.DuckFound();
            }

            // Destroy the duck or deactivate it
            gameObject.SetActive(false);
        }
    }
}