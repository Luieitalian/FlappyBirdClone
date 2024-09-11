using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private TMPro.TextMeshProUGUI pointsText;
    private int points = 0;

    void Start()
    {

    }

    void UpdateUI()
    {
        pointsText.SetText($"Points: {points}");
    }

    public void AddPoint(int val)
    {
        points += val;
        UpdateUI();
    }

}
