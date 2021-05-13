using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class puntosManage : MonoBehaviour
{
    public static puntosManage scoreManager;
    public Text scoreText;

    public int score = 0;
    //public GameObject coinPrefab;

    private void Start()
    {
       
            scoreManager = this;
           

    }
    private void Update()
    {
        if (scoreText == null)
        {
            //Destroy(scoreText);
            //--->score = int.Parse(scoreText.text);
            scoreText = GameObject.Find("Puntos").GetComponent<Text>();
            scoreText.text = "Completado: " + (score * 10) + " %";
        }
    }
    public void RaiseScore(int p)
    {
        score += p;
        //Debug.Log(score);
        scoreText.text = "Completado: " + (score * 10) + " %";

    }
}
