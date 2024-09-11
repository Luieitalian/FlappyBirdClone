using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private TMPro.TextMeshProUGUI pointsText;
    [SerializeField]
    private TMPro.TextMeshProUGUI highestScoreText;
    [SerializeField]
    private GameObject gameUI;
    [SerializeField]
    private GameObject menuUI;

    private int points = 0;
    private int highestScore = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void UpdateGameUI()
    {
        pointsText.SetText($"Points: {points}");
    }

    void UpdateMenuUI()
    {
        highestScoreText.SetText($"Highest Score: {highestScore}");
    }

    void DeleteAllPipes()
    {
        var pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (var item in pipes)
        {
            Destroy(item);
        }
    }

    public void KillPlayer()
    {
        if (points > highestScore) highestScore = points;

        points = 0;
        UpdateGameUI();

        UpdateMenuUI();
        DeleteAllPipes();
        gameUI.SetActive(false);
        menuUI.SetActive(true);
    }

    public void AddPoint(int val)
    {
        points += val;
        UpdateGameUI();
    }

    public void OnPlayPressed()
    {
        DeleteAllPipes();
        gameUI.SetActive(true);
        menuUI.SetActive(false);
    }

    public void OnExitPressed()
    {
        Application.Quit();
    }

}
