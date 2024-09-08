using UnityEngine;

public class MushroomMovement : MonoBehaviour
{
    [SerializeField]
    private float mushroomSpeed = 2f;

    [SerializeField]
    private LayerMask labyrinthLayer;

    private Rigidbody2D mushroomRigidBody;

    private bool moveRight = true;

    void Start()
    {
        mushroomRigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (moveRight)
        {
            mushroomRigidBody.velocity = new Vector2(mushroomSpeed, mushroomRigidBody.velocity.y);
        }
        else
        {
            mushroomRigidBody.velocity = new Vector2(-mushroomSpeed, mushroomRigidBody.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (labyrinthLayer == (labyrinthLayer | (1 << collision.gameObject.layer)))
        {
            moveRight = !moveRight;
        }
    }
}
