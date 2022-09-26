using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingFountain : MonoBehaviour
{
    public float radius=3f;
    public float spawnCountdown=3f;
    public float spawnCountdownInit;
    public float lifespan=20f;

    private Vector3 area;
    public charUnit unit;
    
    public GameObject healthPickup;
    void Start(){
        spawnCountdownInit=spawnCountdown;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime;
        lifespan-=Time.deltaTime;
        if(spawnCountdown<=0){
            area = new Vector3(Random.Range(-radius, radius)+unit.transform.position.x, Random.Range(-radius, radius)+unit.transform.position.y, 0);
            Instantiate(healthPickup, area, transform.rotation);

            spawnCountdown=spawnCountdownInit;
        }
        if(lifespan<=0){

            this.gameObject.SetActive(false);
        }
    }
}
