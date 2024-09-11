using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{

    void Awake()
    {
        var player = transform.Find("Player").gameObject;
        var playerRect = player.transform.GetComponent<RectTransform>().rect;
        playerRect.position = new Vector3(-290, 0);
    }

}
