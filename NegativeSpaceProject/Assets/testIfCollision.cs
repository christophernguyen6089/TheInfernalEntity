using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testIfCollision : MonoBehaviour
{
    private Collider2D ourCollider;

    // Start is called before the first frame update
    // Start()
    //{
        //ourCollider = GetComponent<Collider2D>();    
    //}

    private void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Trigger!");
        gameObject.SetActive(false);

        characterMove.DebugLogPrint("Hello, world.");
        //insert method for setting player's HP
    }

    // Update is called once per frame
    
}
