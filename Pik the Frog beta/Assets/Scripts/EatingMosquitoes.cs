using UnityEngine;
using TMPro;

public class EatingMosquitoes : MonoBehaviour
{
    [SerializeField]
    private GameObject mosquitoesGroup;

    [SerializeField]
    private TextMeshProUGUI UIMosquitoCounter;

    public int mosquitoCounter;

    void Start()
    {
        mosquitoCounter = mosquitoesGroup.transform.childCount;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag == "Food")
        {
            Debug.Log("Íÿì");
            mosquitoCounter--;

            UIMosquitoCounter.text = mosquitoCounter.ToString();

            Destroy(collision.gameObject);
        }
    }
}
