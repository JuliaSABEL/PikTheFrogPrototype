using System;
using UnityEngine;

public class CollisionWithMushroom : MonoBehaviour
{
    public Action OnCollisionWithMushroom;

    void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag == "Enemy")
        {
            OnCollisionWithMushroom?.Invoke();
        }
    }
}
