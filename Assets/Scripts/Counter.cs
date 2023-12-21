using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

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
            LoadScene();
        }
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectable.total}";
    }

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.Log($"Loading scene: {sceneToLoad}");
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene name not set.");
        }
    }
}
