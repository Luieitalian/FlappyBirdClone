using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{

    void OnEnable()
    {
        var player = transform.Find("Player").gameObject;
        var playerRectTransform = player.transform.GetComponent<RectTransform>();
        playerRectTransform.anchoredPosition = new Vector3(173, 0);
    }

    void OnDisable()
    {
        var player = transform.Find("Player").gameObject;
        var playerRectTransform = player.transform.GetComponent<RectTransform>();
        playerRectTransform.anchoredPosition = new Vector3(173, 0);
    }

}
