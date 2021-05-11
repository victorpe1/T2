using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaContador : MonoBehaviour
{
    public static vidaContador scoreManager;
    public Image[] vidas;
    public int vidaRestantes;

    private void Start()
    {
        
            scoreManager = this;
        
    }

    public void perderVida()
    {
        vidaRestantes--;
        vidas[vidaRestantes].enabled = false;

        if (vidaRestantes == 0)
        {
            FindObjectOfType<levelManager>().Restart();
        }
    }
}
