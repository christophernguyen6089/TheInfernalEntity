﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountainSpawner : MonoBehaviour
{
    public float radius;
    public float spawnCountdown;
    public float spawnCountdownInit;
    public float lifespan;

    private Vector3 area;

    public charUnit unit;
    //hard coded cause lol

    
    public GameObject healthPickup;
    
    void Start(){
        spawnCountdownInit = spawnCountdown;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime;
        lifespan-=Time.deltaTime;
        if(spawnCountdown<=0){
            area = new Vector3(Random.Range(-radius, radius)+transform.position.x, Random.Range(-radius, radius)+transform.position.x, 0);
            Instantiate(healthPickup, area, transform.rotation);
            //BE AWARE OF HARDCODED COORDINATES
            spawnCountdown=spawnCountdownInit;
        }
        if(lifespan<=0){

            this.gameObject.SetActive(false);
        }
    }
}
