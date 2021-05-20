using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaContador : MonoBehaviour
{
    public static vidaContador scoreManager;
    public Image[] vidas;
    public int vidaRestantes;

    public GameObject muerte;

    private void Start()
    {
        
            scoreManager = this;
        
    }

    IEnumerator xd()
    {

        yield return new WaitForSeconds(2f);

        FindObjectOfType<levelManager>().Restart();
    }

    public void perderVida()
    {
        vidaRestantes--;
        vidas[vidaRestantes].enabled = false;

        if (vidaRestantes == 0)
        {

            Instantiate(muerte, transform.position, transform.rotation);
            GetComponent<Renderer>().enabled = false;
            StartCoroutine(xd());

            
        }
    }

}
