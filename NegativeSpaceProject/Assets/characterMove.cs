using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public Rigidbody2D playerBody;
    private Vector2 moveDirection = Vector2.zero;

    private Camera ourCamera;
    //public Collider2D theirCollider;
    private float xMovement, yMovement;
    
    // Start is called before the first frame update
    private void Start()
    {
        ourCamera = Camera.main;
    }

    private void Update(){
        xMovement=Input.GetAxis("Horizontal");
        yMovement=Input.GetAxis("Vertical");
        playerBody.velocity = new Vector2(xMovement*10f, yMovement*10f);
    }

    public static void DebugLogPrint(string message){
        Debug.Log(message);
    }
}
