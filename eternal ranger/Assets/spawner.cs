using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject rock;
    public float radius;
    public float timer=0;
    public float spawnrate=2;
    public float offset =5;
    // Start is called before the first frame update
    void Start()
    {
        rando();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate){
            timer=timer+Time.deltaTime;
        }
        else{
            rando();
            timer=0;
        }
    }
    void rando(){
        float lowpoint=transform.position.x-offset;
        float highestPoint = transform.position.x + offset;
        Instantiate(rock, new Vector3( Random.Range(lowpoint, highestPoint),transform.position.y ) ,Quaternion.identity);
        
        
        
    }
}

