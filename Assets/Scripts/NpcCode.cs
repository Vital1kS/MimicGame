using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCode : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D mimicrb;
    private GameObject mimiñ;
    public float viewDistance;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mimiñ = GameObject.Find("Mimic");
        mimicrb = mimiñ.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y+4.1f), Vector2.up);
        RaycastHit2D ray1 = Physics2D.Raycast(new Vector2(transform.position.x + 4.1f, transform.position.y), 3*Vector2.right);
        RaycastHit2D ray2 = Physics2D.Raycast(new Vector2(transform.position.x - 4.1f, transform.position.y), 3*Vector2.left);
        RaycastHit2D ray3 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - 4.1f), 3*Vector2.down);
        if(ray.distance < viewDistance && ray.rigidbody == mimicrb)
        {

            rb.velocity = Vector2.up * 5;
        }
        if (ray1.distance < viewDistance && ray1.rigidbody == mimicrb)
        {
            rb.velocity = Vector2.right * 5;
        }
        if (ray2.distance < viewDistance && ray2.rigidbody == mimicrb)
        {
            rb.velocity = Vector2.left * 5;
        }
        if (ray3.distance < viewDistance && ray3.rigidbody == mimicrb)
        {
            rb.velocity = Vector2.down * 5;
        }
        Debug.Log("");
    }
}
