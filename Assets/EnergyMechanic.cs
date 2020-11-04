﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMechanic : MonoBehaviour
{
    public float timeRemaining;
    public GameObject robot;

    public Sprite[] spriteArr;
    SpriteRenderer sp;

    void Start(){
        sp = robot.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        timeRemaining -= Time.deltaTime;
        int seconds = (int)timeRemaining;
        if (seconds >= 20){
            sp.sprite = spriteArr[0];
        }
        else if (seconds >= 15 && seconds < 20)
        {
            sp.sprite = spriteArr[1];
        }
        else if(seconds >= 10 && seconds < 15)
        {
            sp.sprite = spriteArr[2];

        }
        else if(seconds >= 5 && seconds < 10){
            sp.sprite = spriteArr[3];
        }
        else if(seconds >=0 && seconds < 5){
            sp.sprite = spriteArr[4];
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Star")
           {
                timeRemaining = 25;
           }
    }
}