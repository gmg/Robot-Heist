using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static event Action<int> OnPickUpCollected;
    [SerializeField] private int points = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            OnPickUpCollected?.Invoke(points);
        }
    }
}
