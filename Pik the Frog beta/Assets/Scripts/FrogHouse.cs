using UnityEngine;

public class FrogHouse : MonoBehaviour
{
    [SerializeField]
    private MosquitoCollector mosquitoCollector;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (mosquitoCollector.MosquitoCounter == 0)
        {
            Time.timeScale = 0f;
        }
    }
}
