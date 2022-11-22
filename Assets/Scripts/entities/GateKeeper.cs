using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeper : MonoBehaviour
{

    public static GateKeeper instance;
    Rigidbody2D rb;
    Vector2 startPos;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    public void TryCatchBall()
    {
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), 0) * 20f, ForceMode2D.Impulse);
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
