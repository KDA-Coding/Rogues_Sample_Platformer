using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{

    [SerializeField] int scoreToAdd = 1;
    [SerializeField] TextMeshProUGUI scoreText;
    int currentScore = 0;


    public void AddScore()
    {
        currentScore += scoreToAdd;
        scoreText.text = "Coins: " + currentScore;
    }
}
