using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public Rigidbody2D playerBody;
    private Vector2 moveDirection = Vector2.zero;

    private Camera ourCamera;
    private float xMovement, yMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        ourCamera = Camera.main;
    }

    void Update(){
        xMovement=Input.GetAxis("Horizontal");
        yMovement=Input.GetAxis("Vertical");
        playerBody.velocity = new Vector2(xMovement*25f, yMovement*25f);
    }
}
