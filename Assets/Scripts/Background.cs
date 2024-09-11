using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField]
    private RawImage image;
    [SerializeField]
    private float backgroundSpeed;
    [SerializeField]
    private GameObject pipeGroup;
    [SerializeField]
    private float spawnOffsetX;
    private float spawnOffsetY;
    private readonly float spawnOffsetYRange = 1;
    [SerializeField]
    private float spawnDelay;
    [SerializeField]
    private float cameraOffsetZ;
    [SerializeField]
    private GameManager gameManager;

    void Update()
    {
        image.uvRect = new Rect(image.uvRect.position + new Vector2(backgroundSpeed, 0) * Time.deltaTime, image.uvRect.size);
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            spawnOffsetY = Random.Range(-spawnOffsetYRange, spawnOffsetYRange);
            Instantiate(pipeGroup, new Vector3(spawnOffsetX, spawnOffsetY, cameraOffsetZ), Quaternion.identity, gameObject.transform);
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    void OnEnable()
    {
        StartCoroutine(SpawnPipes());
    }

    void OnDisable()
    {
        StopCoroutine(SpawnPipes());
    }
}
