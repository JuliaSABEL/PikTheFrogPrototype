using UnityEngine;

public class CollisionWithMushroom : MonoBehaviour
{
    public delegate void CollisionWithMushroomEventHandler();

    public event CollisionWithMushroomEventHandler OnCollisionWithMushroom;

    void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag == "Enemy")
        {
            OnCollisionWithMushroom?.Invoke();
        }
    }
}
