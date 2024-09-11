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

    void Start()
    {
        SpawnPipes();
    }

    void Update()
    {
        image.uvRect = new Rect(image.uvRect.position + new Vector2(backgroundSpeed, 0) * Time.deltaTime, image.uvRect.size);
    }

    void SpawnPipes()
    {
        spawnOffsetY = Random.Range(-spawnOffsetYRange, spawnOffsetYRange);
        var newPipeGroup = Instantiate(pipeGroup, new Vector3(spawnOffsetX, spawnOffsetY, cameraOffsetZ), Quaternion.identity, gameObject.transform);
        newPipeGroup.transform.SetAsFirstSibling();
        Invoke(nameof(SpawnPipes), spawnDelay);
    }
}
