using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    private int score;
    [SerializeField] private TMP_Text ScoreUIText = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnEnable() => PickUp.OnPickUpCollected += PickUpCollected;
    private void OnDisable() => PickUp.OnPickUpCollected -= PickUpCollected;

    private void Start()
    {
        score = 0;
    }

    private void PickUpCollected(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        ScoreUIText.text = $"Score: {score}";
    }
}
