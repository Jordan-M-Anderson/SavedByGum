using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gumball : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb2d;
    public GameObject gum;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") {

            Destroy(rb2d.gameObject);

        }

        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            collision.GetComponent<Spider>().speed = 0;
            Instantiate(gum, collision.transform.position, Quaternion.identity);
        }
    }
}
