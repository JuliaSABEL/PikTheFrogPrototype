using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    protected float horizontalMove, verticalMove;

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical");
    }
}
