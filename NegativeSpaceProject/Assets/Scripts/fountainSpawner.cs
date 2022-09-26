using System.Collections;
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
            //instantiates a healing object in the range of the current fountainSpawner's position, within the area of a square that is the length of the radius parameter
            area = new Vector3(Random.Range(-radius, radius)+transform.position.x, Random.Range(-radius, radius)+transform.position.x, 0);
            Instantiate(healthPickup, area, transform.rotation);

            spawnCountdown=spawnCountdownInit;
        }
        if(lifespan<=0){

            this.gameObject.SetActive(false);
        }
    }
}
