using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public charUnit unit;

    public Rigidbody2D playerBody;
    private Vector2 moveDirection = Vector2.zero;

    private float xMovement, yMovement;
    
    // Start is called before the first frame update
    private void Start()
    {
    }

    private void Update(){
        xMovement=Input.GetAxis("Horizontal");
        yMovement=Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift)){
            playerBody.velocity = new Vector3(xMovement*15f, yMovement*15f);
            unit.decreaseParameter=1.5f;
        }
        else{
            playerBody.velocity = new Vector3(xMovement*10f, yMovement*10f);
            unit.decreaseParameter=1f;
        }

        

        
    }

    public static void DebugLogPrint(string message){
        Debug.Log(message);
    }
}
