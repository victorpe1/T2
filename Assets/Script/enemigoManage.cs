using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemigoManage : MonoBehaviour
{

    public GameObject player;

    float speed = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "pikachu"){

            Vector3 direction = (transform.position - collision.transform.position).normalized;

            direction *= -1;

            collision.GetComponent<Rigidbody2D>().AddForce(direction * speed);

            vidaContador.scoreManager.perderVida();
        }
        
    }
}
