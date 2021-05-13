using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medallaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameObject scripter = GameObject.Find("Scripter");
        //scripter.GetComponent<ScoreManager>().RaiseScore(1);
        //ScoreManager.scoreManager.RaiseScore(1);

        playerController.m_playerController.ProgresoUpdate(-1);
        puntosManage.scoreManager.RaiseScore(1);

        Destroy(gameObject);
    }
}
