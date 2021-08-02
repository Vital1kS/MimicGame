using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicMovement : MonoBehaviour
{
    public static float speed = 40;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move(speed);
    }
    void Move(float sp)
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float xMv = x * sp;
        float yMv = y * sp;
        if (!MimicAbilities.isHidding)
        {
            rb.velocity = new Vector2(xMv, yMv);
        }
        if (x == 1)
        {
            this.transform.rotation = Quaternion.AngleAxis(-90, Vector3.forward);
        }
        if (x == -1)
        {
            this.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
        }
        if (y == -1)
        {
            this.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
        }
        if (y == 1)
        {
            this.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        }
    }
}
