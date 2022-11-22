using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public static Arrow instance;
    SpriteRenderer sprite;

    void Awake()
    {
        instance = this;
        sprite = GetComponent<SpriteRenderer>();
    }

    public void ChangeDirection(float val)
    {
        transform.up += new Vector3(val, 0);
    }

    public void SetColor(float val)//changes color of arrow depenging on strength
    {
        sprite.color = new Color(1,1 - val, 1 - val);
    }
}
