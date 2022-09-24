using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testIfCollision : MonoBehaviour
{
    Collider ourCollider;

    // Start is called before the first frame update
    void Start()
    {
        ourCollider = GetComponent<Collider>();    
    }

    private bool OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Trigger!");
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
