using UnityEngine;

public class FrogController : MonoBehaviour
{
    [SerializeField]
    private float frogSpeed = 3f;

    private float horizontalMove, verticalMove;

    private Rigidbody2D frogRigidBody;

    void Start()
    {
        frogRigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void FrogControll()
    {
        if (horizontalMove != 0 || verticalMove != 0)
        {
            Vector2 movement = new Vector2(horizontalMove * frogSpeed, verticalMove * frogSpeed);
            frogRigidBody.velocity = movement;
        }
        else
        {
            frogRigidBody.velocity = Vector2.zero;
        }
    }

    public void PlayerInput()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical"); 
    }
}
