using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    public static playerController m_playerController;
    bool jump;
    bool doubleJump = false;

    new Rigidbody2D rigidbody2D;
    Animator animator;
    SpriteRenderer spriteRenderer;

    //xd
    public Image barraProgreso;
    float puntosActual = 10;
    float puntosMaximo = 10;
    //

    void Start()
    {

        m_playerController = this;
           

        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            rigidbody2D.AddForce(new Vector2(-340f * Time.deltaTime, 0));
            animator.SetBool("moving", true);
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey("right"))
        {
            rigidbody2D.AddForce(new Vector2(340f * Time.deltaTime, 0));
            animator.SetBool("moving", true);
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jump)
            {
                jump = false;
                doubleJump = true;
                animator.SetBool("jump", true);
                rigidbody2D.AddForce(new Vector2(0, 150f));
                
            }
            else if (doubleJump)
            {
                doubleJump = false;
                animator.SetBool("jump", true);
                rigidbody2D.AddForce(new Vector2(0, 100f));
                
            }
        }

        if(!Input.GetKey("right") && !Input.GetKey("left"))
        {
            animator.SetBool("jump", false);
            animator.SetBool("moving", false);
        }

        if (barraProgreso == null)
        {
            barraProgreso = GameObject.Find("barra").GetComponent<Image>();
            barraProgreso.fillAmount = puntosActual / puntosMaximo;
        }

    }
        public void ProgresoUpdate(int cant)
    {
        puntosActual += cant;
        barraProgreso.fillAmount = puntosActual / puntosMaximo;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "suelo")
        {
            animator.SetBool("jump", false);
            jump = true;
            this.transform.parent = collision.transform;
        }
        else if(collision.transform.tag == "caida")
        {
            FindObjectOfType<levelManager>().Restart();

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "suelo")
        {
            this.transform.parent = null;
        }
    }
}
