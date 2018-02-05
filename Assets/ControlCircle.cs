using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCircle : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    public float Speed;
    public int JumpCount;
    // Use this for initialization
    void Start()
    {
        JumpCount = 0;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (JumpCount >= 2) return;
            JumpCount++;
            rigidbody2D.velocity += Vector2.up * Speed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidbody2D.velocity += Vector2.right * Speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidbody2D.velocity += Vector2.left * Speed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpCount = 0;
    }
}
