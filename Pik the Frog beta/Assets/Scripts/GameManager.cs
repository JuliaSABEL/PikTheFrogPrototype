using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private CollisionWithMushroom collisionWithMushroom;

    [SerializeField]
    private HealthController healthController;

    [SerializeField]
    private MosquitoCollector mosquitoCollector;

    [SerializeField]
    private FrogInvulnerability frogInvulnerability;

    [SerializeField]
    private UIManager uIManager;

    void OnEnable()
    {
        collisionWithMushroom.OnCollisionWithMushroom += healthController.DecreaseInHealth;

        healthController.OnHealthController += frogInvulnerability.FrogInvulnerabilityMethod;

        healthController.OnHealthController += uIManager.UpdateHealthUI;

        healthController.OnHealthController += RestartGame;

        mosquitoCollector.OnMosquitoCollector += uIManager.UpdateMosquitoCounterUI;
    }

    void OnDisable()
    {
        collisionWithMushroom.OnCollisionWithMushroom -= healthController.DecreaseInHealth;

        healthController.OnHealthController -= frogInvulnerability.FrogInvulnerabilityMethod;

        healthController.OnHealthController -= uIManager.UpdateHealthUI;

        healthController.OnHealthController -= RestartGame;

        mosquitoCollector.OnMosquitoCollector -= uIManager.UpdateMosquitoCounterUI;
    }

    void RestartGame()
    {
        if (healthController.FrogHearts == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
