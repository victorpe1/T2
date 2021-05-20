using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public GameObject pj;


    private void Update()
    {
        Vector3 position = transform.position;
        position.x = pj.transform.position.x;
        position.y = pj.transform.position.y;
        transform.position = position;

    }
}
