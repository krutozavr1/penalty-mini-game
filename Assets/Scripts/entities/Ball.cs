using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speedMultiplyer;
    public static Ball instance;
    Rigidbody2D rb;
    Vector3 startPos;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        instance = this;
    }

    public void SetVelocity(Vector2 dir, float str)
    {
        rb.AddForce(dir * str * speedMultiplyer, ForceMode2D.Impulse);
    }

    public void ResetPosition()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
    }
}
