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

    
    public GameObject healthPickup;
    
    
    void Start(){
        spawnCountdownInit = spawnCountdown;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime*decreaseParameter;
        lifespan-=Time.deltaTime;
        if(spawnCountdown<=0){
            area = new Vector3(transform.position.x, Random.Range(-radius, radius)+transform.position.y, 0);
            Instantiate(healthPickup, area, transform.rotation);
            
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
