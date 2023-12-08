using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        Dock();
    }
    void Dock(){
        if((transform.position.x<=-7.00)||(transform.position.x>=8))
        {
            
        Destroy(gameObject);
        
        }

 
    }
   
    }

        
    

