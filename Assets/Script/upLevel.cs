using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (puntosManage.scoreManager.score == 10)
        {
            Debug.Log(puntosManage.scoreManager.score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
 
}
