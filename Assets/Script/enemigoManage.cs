using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemigoManage : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "pikachu"){
                vidaContador.scoreManager.perderVida();
        }
        
    }
}
