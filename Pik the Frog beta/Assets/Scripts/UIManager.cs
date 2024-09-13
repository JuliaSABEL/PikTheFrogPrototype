using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public HealthController healthController;

    [SerializeField]
    private Image[] frogHeartsImg = new Image[3];

    public void UpdateUI()
    {
        frogHeartsImg[2 - healthController.FrogHearts].enabled = false;
    }
}
