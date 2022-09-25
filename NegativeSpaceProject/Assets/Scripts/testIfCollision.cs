using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testIfCollision : MonoBehaviour
{
    public charUnit unit;
    public float healAmount;

    private Collider2D ourCollider;
    public Rigidbody2D rb;
    public Vector3 speed;

    void Start(){
        speed = new Vector3(3,0,0);
        gameObject.GetComponent<Rigidbody2D>().velocity = speed;
    }

    private void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Trigger!");
        //at this rate, im spaghetti coding, but who cares
        unit.heal(healAmount);


        Destroy(this.gameObject);

        characterMove.DebugLogPrint("Hello, world.");
        //insert method for setting player's HP
    }

    // Update is called once per frame
    
}
