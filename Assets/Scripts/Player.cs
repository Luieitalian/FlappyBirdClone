using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float jumpPower = 30f;
    [SerializeField]
    private Rigidbody2D rb2D;

    private bool jumpRequested;

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
            rb2D.AddRelativeForce(jumpPower * Time.fixedDeltaTime * Vector2.up, ForceMode2D.Impulse);
            jumpRequested = false;
        }
    }
}
