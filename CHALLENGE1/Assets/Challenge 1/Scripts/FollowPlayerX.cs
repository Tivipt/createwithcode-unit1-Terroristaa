﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(30, 0, 10);
    }
    
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}