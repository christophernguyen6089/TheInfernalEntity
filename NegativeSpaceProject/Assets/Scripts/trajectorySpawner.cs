using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trajectorySpawner : MonoBehaviour
{
    public float radius;
    public float spawnCountdown;
    public float spawnCountdownInit;
    public float lifespan;

    public float decreaseParameter;
    private Vector3 area;

    public charUnit unit;
    //hard coded cause lol

    
    public GameObject healthPickup;
    
    
    void Start(){
        spawnCountdownInit = spawnCountdown;
        //pickupRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime*decreaseParameter;
        lifespan-=Time.deltaTime;
        if(spawnCountdown<=0){
            area = new Vector3(transform.position.x, Random.Range(-radius, radius)+transform.position.y, 0);
            Instantiate(healthPickup, area, transform.rotation);
            
            //BE AWARE OF HARDCODED COORDINATES
            spawnCountdown=spawnCountdownInit;
        }
        if(lifespan<=0){

            this.gameObject.SetActive(false);
        }
        if(charUnit.gameOverFlag==true){
            
            decreaseParameter=0;
        }
    }
}
