using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ground : MonoBehaviour
{
     public void OnCollisionEnter2D(Collision2D collision)  {
        if(collision.gameObject.CompareTag("rock")){
            Destroy(collision.gameObject);
            Debug.Log("yo");
        }
    }
}
