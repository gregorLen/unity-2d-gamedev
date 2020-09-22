using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    // configuration parameters
    [Range(0.2f, 3.0f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerHit = 83;
    [SerializeField] TextMeshProUGUI scoreText;
    
    // state
    [SerializeField] int currentScore = 0; 
    
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = currentScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerHit;
        scoreText.text = currentScore.ToString();
    }
}
