using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public void playgame(){
        SceneManager.LoadScene("Shooting scenes");
    }
}
