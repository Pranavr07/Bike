using UnityEngine;

public class TrapReset : MonoBehaviour
{
    public GameObject hero1;
    public GameObject hero2;

    private Vector3 hero1StartPos;
    private Vector3 hero2StartPos;

    void Start()
    {
        // Save starting positions of both heroes
        if (hero1 != null)
            hero1StartPos = hero1.transform.position;

        if (hero2 != null)
            hero2StartPos = hero2.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == hero1)
        {
            ResetHero(hero1, hero1StartPos);
        }
        else if (other.gameObject == hero2)
        {
            ResetHero(hero2, hero2StartPos);
        }
    }

    void ResetHero(GameObject hero, Vector3 startPos)
    {
        hero.transform.position = startPos;

        Rigidbody2D rb = hero.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
