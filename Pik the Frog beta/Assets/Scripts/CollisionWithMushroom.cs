using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionWithMushroom : MonoBehaviour
{
    [SerializeField]
    private Image[] frogHearts = new Image[3];

    [SerializeField]
    private int toadHeart = 3;

    private int originalLayer;

    private SpriteRenderer frogSpriteRenderer;

    void Start()
    {
        originalLayer = gameObject.layer;

        frogSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionTag = collision.gameObject.tag;

        if (collisionTag == "Enemy")
        {
            Debug.Log("Тык");
            frogHearts[3 - toadHeart].enabled = false;

            toadHeart--;

            StartCoroutine(ToadInvulnerability());

            if (toadHeart == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void SetTransperancy(float alpha)
    {
        Color color = frogSpriteRenderer.color;

        color.a = alpha;

        frogSpriteRenderer.color = color;
    }

    IEnumerator ToadInvulnerability()
    {
        gameObject.layer = LayerMask.NameToLayer("Inactive Player");

        SetTransperancy(0.2f);

        yield return new WaitForSeconds(3f);

        SetTransperancy(1f);

        gameObject.layer = originalLayer;
    }
}
