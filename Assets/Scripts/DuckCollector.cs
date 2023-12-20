using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCollector : MonoBehaviour
{
    private int itemCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RubberDuck") // Assuming "RubberDuck" is the name of your rubber ducks
        {
            Destroy(other.gameObject);
            itemCount++;

            // Find the GameManager in the scene and call its DuckFound method
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.DuckFound();
            }

            // Optional: Debug information
            Debug.Log($"Duck collected! Total Ducks: {itemCount}");
        }
    }
}

