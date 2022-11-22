using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speedMultiplyer;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void SetVelocity(Vector2 dir, float str)
    {
        rb.AddForce(dir * str * speedMultiplyer, ForceMode2D.Impulse);
    }
}
