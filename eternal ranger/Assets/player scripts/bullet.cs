using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;

public class bullet : MonoBehaviour
{
    public logic lo;

    void Start(){
        lo=GameObject.FindGameObjectWithTag("lok").GetComponent<logic>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.GetComponent<newrock>()){
            Destroy(collision.gameObject);
            Debug.Log("gp gay");
            lo.addscore();
            Destroy(gameObject);
            
        }
    }   
}
