using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldBounds : MonoBehaviour
{
    [SerializeField]
    private RectTransform canvasRectTransform;

    private BoxCollider2D topCollider;
    private BoxCollider2D bottomCollider;

    [SerializeField]
    private float xOffset, yOffset;

    void Start()
    {
        topCollider = transform.Find("Top").GetComponent<BoxCollider2D>();
        bottomCollider = transform.Find("Bottom").GetComponent<BoxCollider2D>();

        topCollider.size = new Vector2(canvasRectTransform.rect.width, 1);
        bottomCollider.size = new Vector2(canvasRectTransform.rect.width, 1);

        topCollider.offset = new Vector2(xOffset, yOffset);
        bottomCollider.offset = new Vector2(xOffset, -yOffset);
    }

}
