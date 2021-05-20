using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //PlayerController.playerController.LifeUpdate(-1);

        if (puntosManage.scoreManager.score == 10)
        {
            SceneManager.LoadScene("Escena_4");
        }

        //Destroy(transform.parent.gameObject);
    }
}
