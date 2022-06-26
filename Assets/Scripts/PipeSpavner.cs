using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpavner : MonoBehaviour
{
    public float maxTime;
    private float  timer = 0;
    public GameObject pipe;
    public float height;
    private void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0); 
    }
    private void Update()
    {
        if(timer > maxTime)
        {

            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position = new Vector3 (0, Random.Range(-height,height),0);
            Destroy(newPipe,10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
