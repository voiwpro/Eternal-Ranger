using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playershoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject bulletprefab;
    [SerializeField]
    private float bulletspeed;
    private bool fireconti;

    [SerializeField]
    private float _timebetweenshots;
    private float lastfiretime=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(fireconti){
        float timesincelastfire=Time.time - lastfiretime;
        if (timesincelastfire>=_timebetweenshots){
            firebullet();
            lastfiretime=Time.time;
        }
        

    }
    }
    private void firebullet(){
        GameObject bullet=Instantiate(bulletprefab,transform.position,transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.velocity=bulletspeed*transform.up;
    }
    public void OnFire(InputValue inputValue){
        fireconti=inputValue.isPressed;
        Debug.Log("ho");
    }
}
