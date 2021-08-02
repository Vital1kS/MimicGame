using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicAbilities : MonoBehaviour
{
    private Animator animator;
    private GameObject mimic;
    public static bool isHidding = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        mimic = GameObject.Find("Mimic");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Hide();
        Dash();
    }
    void Hide()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            isHidding = !isHidding;
            if (!isHidding)
            {
                animator.Play("MimicOpen");
            }
            else
            {
                animator.Play("MimicClose");
            }
        }
    }
    void Dash()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            MimicMovement.speed = 100;
        }
    }
}
