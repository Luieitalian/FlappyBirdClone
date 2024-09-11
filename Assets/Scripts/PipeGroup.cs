using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGroup : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(-speed, 0);
        Invoke(nameof(Kill), speed / 0.2f);
    }

    void Kill()
    {
        Destroy(gameObject);
    }
}
