﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float reapeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        reapeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - reapeatWidth)
        {
            transform.position = startPos;
        }
    }
}