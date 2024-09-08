using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private FrogController frogController;
    [SerializeField]
    private CameraControl cameraControl;

    void Update()
    {
        frogController.PlayerInput();
    }

    void FixedUpdate()
    {
        frogController.FrogControll();

        cameraControl.CameraFollow();
    }
}
