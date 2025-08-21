using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerPro5 : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive ;
    public Button playAgainButton;
    public GameObject titleScreen;
    
    private int score;
    private float spawnRate = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
    }

    private IEnumerator SpawnTargets()
    {
        while (true)
        {
            if (isGameActive)
            {
                yield return new WaitForSeconds(spawnRate);
                int index = Random.Range(0, targets.Count);
                Instantiate(targets[index]);
            }
            else
            {
                break;
            }
        }
    }

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        scoreText.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
        score = 0;
        StartCoroutine("SpawnTargets");
        UpdateScore(0);
    }
    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOVer()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        playAgainButton.gameObject.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
