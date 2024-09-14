using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private HealthController healthController;

    [SerializeField]
    private MosquitoCollector mosquitoCollector;

    [SerializeField]
    private Image[] frogHeartsImg = new Image[3];

    [SerializeField]
    private TextMeshProUGUI UIMosquitoCounter;

    public void UpdateHealthUI()
    {
        frogHeartsImg[2 - healthController.FrogHearts].enabled = false;
    }

    public void UpdateMosquitoCounterUI()
    {
        UIMosquitoCounter.text = mosquitoCollector.MosquitoCounter.ToString();
    }
}
