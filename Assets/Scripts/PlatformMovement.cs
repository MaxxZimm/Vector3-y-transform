﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float xSpeed;
    private bool right;

    public GameObject prefab1;
    public GameObject prefab2;

    public GameObject BaseDer;
    public GameObject BaseIzq;

    // Start is called before the first frame update
    void Start()
    {
        right = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(right == true){
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position += new Vector3(-xSpeed, 0, 0);
        }
        if(transform.position.x > 1.85)
        {
            right = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = BaseDer.transform.position + Vector3.up;
        }
        else if (transform.position.x < -1.85)
        {
            right = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = BaseIzq.transform.position + Vector3.up;
        }

    }
}
