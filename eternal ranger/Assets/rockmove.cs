using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        Dock();
    }
    void Dock(){
        if((transform.position.x<=-7.00)||(transform.position.x>=8))
        {
            Debug.Log(transform.position.x);
        Destroy(gameObject);
        }
    }
}
