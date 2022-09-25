using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testIfCollision : MonoBehaviour
{
    public charUnit unit;
    public float healAmount;

    public Collider2D ourCollider;
    public Rigidbody2D rb;
    public float xSpeed, ySpeed;

    private Vector3 speed;

    void Start(){
        if(xSpeed != 0 || ySpeed != 0){
            speed = new Vector3(xSpeed,ySpeed,0);
            gameObject.GetComponent<Rigidbody2D>().velocity = speed;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            
            unit.heal(healAmount);
        }
        

        characterMove.DebugLogPrint(collider.gameObject.tag);
        Destroy(this.gameObject);

        //insert method for setting player's HP
    }

    // Update is called once per frame
    
}
