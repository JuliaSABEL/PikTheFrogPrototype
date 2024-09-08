using UnityEngine;

public class FrogHouse : MonoBehaviour
{
    [SerializeField]
    private EatingMosquitoes eatingMosquitoes;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (eatingMosquitoes.mosquitoCounter == 0)
        {
            Time.timeScale = 0f;
        }
    }
}
