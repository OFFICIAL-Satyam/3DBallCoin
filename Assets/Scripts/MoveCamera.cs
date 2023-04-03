using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject ballsphere;

    private Vector3 distance;
    
    void Start()
    {
        distance = transform.position - ballsphere.transform.position;
        
    }

    
    void Update()
    {
       transform.position  = distance + ballsphere.transform.position;
        
    }
}
