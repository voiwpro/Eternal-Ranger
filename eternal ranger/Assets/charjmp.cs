using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charjmp : MonoBehaviour
{
    public Rigidbody2D myRig;
    public float jmpstrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
        myRig.velocity = Vector2.up *jmpstrength;
        }
      
    }
}
