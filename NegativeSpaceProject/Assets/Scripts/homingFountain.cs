using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingFountain : MonoBehaviour
{
    public float radius=3f;
    public float spawnCountdown=3f;
    public float lifespan=20f;

    private float decreaseParameter=1f;
    private Vector3 area;

    public charUnit unit;
    //hard coded cause lol

    
    public GameObject healthPickup;
    

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime*decreaseParameter;
        lifespan-=Time.deltaTime;
        if(spawnCountdown<=0){
            area = new Vector3(Random.Range(-radius, radius)+unit.transform.position.x, Random.Range(-radius, radius)+unit.transform.position.y, 0);
            Instantiate(healthPickup, area, transform.rotation);
            //BE AWARE OF HARDCODED COORDINATES
            spawnCountdown=1f;
        }
        if(lifespan<=0){

            this.gameObject.SetActive(false);
        }
        if(charUnit.gameOverFlag==true){
            characterMove.DebugLogPrint("Game over from fountain spawner.");
            decreaseParameter=0;
        }
    }
}
