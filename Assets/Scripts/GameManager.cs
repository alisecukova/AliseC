using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalDucks = 10;
    private int foundDucks = 0;

    public TMP_Text ducksNeededText;
    public TMP_Text ducksFoundText;

    private void Start()
    {
        UpdateUI();
    }

    public void DuckFound()
    {
        foundDucks++;

        if (foundDucks >= totalDucks)
        {
            EndGame();
        }

        UpdateUI();
    }

    private void EndGame()
    {
        Debug.Log("Congratulations! You found all the rubber ducks!");

        // Load the main menu scene (replace "MainMenu" with the actual scene name)
        SceneManager.LoadScene("MainMenu");
    }

    private void UpdateUI()
    {
        ducksNeededText.text = "Ducks Needed: " + totalDucks;
        ducksFoundText.text = "Ducks Found: " + foundDucks;
    }
}
