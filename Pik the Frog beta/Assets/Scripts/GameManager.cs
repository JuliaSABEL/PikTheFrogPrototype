using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CollisionWithMushroom collisionWithMushroom;

    public HealthController healthController;

    public FrogInvulnerability frogInvulnerability;

    public UIManager uIManager;

    private void OnEnable()
    {
        collisionWithMushroom.OnCollisionWithMushroom += healthController.DecreaseInHealth;

        collisionWithMushroom.OnCollisionWithMushroom += frogInvulnerability.FrogInvulnerabilityMethod;

        collisionWithMushroom.OnCollisionWithMushroom += uIManager.UpdateUI;

        collisionWithMushroom.OnCollisionWithMushroom += RestartGame;
    }

    private void OnDisable()
    {
        collisionWithMushroom.OnCollisionWithMushroom -= healthController.DecreaseInHealth;

        collisionWithMushroom.OnCollisionWithMushroom -= uIManager.UpdateUI;

        collisionWithMushroom.OnCollisionWithMushroom -= RestartGame;
    }

    private void RestartGame()
    {
        if (healthController.FrogHearts == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
