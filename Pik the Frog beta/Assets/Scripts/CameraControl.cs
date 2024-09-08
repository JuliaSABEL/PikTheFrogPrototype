using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private Transform frog;

    [SerializeField]
    private Vector3 offset;

    [SerializeField]
    private float smoothSpeed = 0.125f;

    public void CameraFollow()
    {
        Vector3 desiredPosition = frog.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
