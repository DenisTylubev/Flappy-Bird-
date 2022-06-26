using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speedPipe;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.left * speedPipe * Time.deltaTime;
    }
}
