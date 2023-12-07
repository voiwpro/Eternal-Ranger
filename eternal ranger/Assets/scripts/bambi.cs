using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambi : MonoBehaviour
{
    public float movementhor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movementhor= Input.GetAxisRaw("Horizontal");
       transform.position+= new Vector3(movementhor,0f,0f)*Time.deltaTime*3;
    }
}
