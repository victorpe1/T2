using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject pj;

    private void Update()
    {
        Vector3 position = transform.position;
        position.x = pj.transform.position.x;
        transform.position = position;
    }
}
