using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountainSpawner : MonoBehaviour
{
    private float radius;
    private float spawnInterval;
    private float spawnCountdown;
    private float decreaseParameter;
    private Vector3 area;


    
    //hard coded cause lol

    
    public GameObject healthPickup;
    
    
    // Start is called before the first frame update
    void Start()
    {
        radius=3f;
        spawnCountdown=2f;
        decreaseParameter=1f;

        //IMPORTANT!!!!!!!!!!!!!!!!!!!!!
        transform.position = new Vector3(5,5,0);
        //IMPORTANT!!!!!!!!!!!!!!!!!!!!!
        
        //BE AWARE OF HARDCODED COORDINATES
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown-=Time.deltaTime*decreaseParameter;
        if(spawnCountdown<=0){
            area = new Vector3(Random.Range(-radius, radius)+transform.position.x, Random.Range(-radius, radius)+transform.position.y, 0);
            Instantiate(healthPickup, area, transform.rotation);
            //BE AWARE OF HARDCODED COORDINATES
            spawnCountdown=1f;
        }
    }
}
