using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cameraFollow : MonoBehaviour
{
    private float FollowSpeed = 5f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -100f);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
