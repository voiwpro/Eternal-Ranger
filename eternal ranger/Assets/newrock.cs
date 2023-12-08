using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newrock : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnCollisionEnter2D(Collision2D collision)  {
        if(collision.gameObject.CompareTag("ground")){
            Destroy(gameObject);
            Debug.Log("yo");
            SceneManager.LoadScene("end game");
        }
}
}
