using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    private TMPro.TMP_Text text;
    private int count;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    private void OnEnable() => Collectable.OnCollected += OnCollectibleCollected;
    private void OnDisable() => Collectable.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();

        if (count >= Collectable.total)
        {
            LoadMainMenuScene();
        }
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectable.total}";
    }

    void LoadMainMenuScene()
    {
        Debug.Log("All collectibles collected. Loading Main Menu scene.");

        // Load the main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
