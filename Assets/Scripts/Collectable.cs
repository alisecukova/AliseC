using System;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;

    void Awake() => total++; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
