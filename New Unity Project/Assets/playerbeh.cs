using UnityEngine;
using System;

public class playerbeh : MonoBehaviour
{
    public Animator anim;
    private float move = 10f;
    private Rigidbody2D pl;
    private Vector3 movedir;
    int count = 0;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        pl = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        animation_motion();
        facemouse();
    }
    private void FixedUpdate()
    {
        pl.velocity = movedir * move;
    }
    private void animation_motion()
    {

        float moveX = 0f, moveY = 0f;
        if (Input.GetKey("w"))
        {
            count = 0;
            anim.SetBool("walkf", false); anim.SetBool("walkl", false); anim.SetBool("walkr", false);
            anim.SetBool("walkb", true);
            moveY = 1f;
        }
        else if (Input.GetKey("s"))
        {
            count = 0;
            anim.SetBool("walkl", false); anim.SetBool("walkr", false); anim.SetBool("walkb", false);
            anim.SetBool("walkf", true);
            moveY = -1f;
        }
        else if (Input.GetKey("a"))
        {
            count = 1;
            anim.SetBool("walkf", false); anim.SetBool("walkl", false); anim.SetBool("walkb", false);
            anim.SetBool("walkr", true);
            moveX = 1f;
        }
        else if (Input.GetKey("d"))
        {
            count = 0;
            anim.SetBool("walkf", false); anim.SetBool("walkr", false); anim.SetBool("walkb", false);
            anim.SetBool("walkl", true);
            moveX = -1f;
        }
        else if (Input.GetKeyDown("space"))
        {
            anim.SetBool("walkf", false); anim.SetBool("walkb", false); anim.SetBool("walkl", false); anim.SetBool("walkr", false);
            if (count == 1)
                anim.SetTrigger("attackl");
            if (count == 0)
                anim.SetTrigger("attack");
        }
        else
        {
            anim.SetBool("walkf", false); anim.SetBool("walkl", false); anim.SetBool("walkr", false); anim.SetBool("walkb", false);
        }
        movedir = new Vector3(moveX, moveY).normalized;
    }
    void facemouse()
    {
        Vector3 mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        float x, y;
        x = mouse.x - transform.position.x;
        y = mouse.y - transform.position.y;
        Debug.Log(y);
        if(y<-2)
        {
            anim.SetBool("ir", false); anim.SetBool("il", false);
            anim.SetBool("ib", true);
        }
        else if (y > 2)
        {
            anim.SetBool("ir", false); anim.SetBool("il", false);
            anim.SetBool("ib", false);
        }
        else if (x > 0 && -2<y && y<2)
        {
            anim.SetBool("ir", false); anim.SetBool("ib", false);
            anim.SetBool("il", true);
        }
        else if (x < 0 && -2<y && y<2)
        {
            anim.SetBool("il", false); anim.SetBool("ib", false);
            anim.SetBool("ir", true);
        }
    }
}