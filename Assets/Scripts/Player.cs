using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private float jumpPower = 4f;
    [SerializeField]
    private float rotationPower = 4f;
    private Rigidbody2D rb2D;

    private bool jumpRequested;

    void Start() { rb2D = GetComponent<Rigidbody2D>(); }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            jumpRequested = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpRequested)
        {
            rb2D.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
            jumpRequested = false;
        }

        transform.rotation = Quaternion.Euler(0, 0, rb2D.velocity.y * rotationPower);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Pipe"))
        {
            gameManager.KillPlayer();
        }
        else if (collider.CompareTag("PointTrigger"))
        {
            gameManager.AddPoint(1);
        }
    }
}
