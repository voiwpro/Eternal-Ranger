using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockemove : MonoBehaviour
{
    // Start is called before the first frame update
   void Start(){

   }
   public void OnTriggerEnter2D(Collider2D collision){
    Destroy(gameObject);
   }
}
