using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject winText;
    public GameObject reStart;
    void Awake()
    {
        winText.SetActive(false);
        reStart.SetActive(false);
    }

    public void scoreUp()
    {
        score++;
        if (score >= 5)
        {
            Win();
        }
    }

    void Win()
    {
        winText.SetActive(true);
        reStart.SetActive(true);
    }

    public void Restart()
    {
        
        SceneManager.LoadScene("Game");
    }
}
