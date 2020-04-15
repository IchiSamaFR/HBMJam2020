﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDeadArea : MonoBehaviour
{
    public MouvementBall mouvementBall;
    public GameObject Ball;
    public int player = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Ball)
        {
            mouvementBall.RestartBall(player);
        }
    }
}
