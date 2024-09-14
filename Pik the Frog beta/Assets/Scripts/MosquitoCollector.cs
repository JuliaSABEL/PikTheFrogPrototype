using System;
using UnityEngine;

public class MosquitoCollector : MonoBehaviour
{
    public Action OnMosquitoCollector;

    private int mosquitoCounter;

    [SerializeField]
    private GameObject mosquitoesGroup;

    public int MosquitoCounter
    {
        get { return mosquitoCounter; }
        set { mosquitoCounter = value; }
    }

    void Start()
    {
        mosquitoCounter = mosquitoesGroup.transform.childCount;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag == "Food")
        {
            mosquitoCounter--;

            Destroy(collision.gameObject);

            OnMosquitoCollector?.Invoke();
        }
    }
}
