using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logic : MonoBehaviour
{
    public int kp=1;
    public int score=0;
    public Text textscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void addscore(){
        score+=kp;
        textscore.text=score.ToString();
    }
}
