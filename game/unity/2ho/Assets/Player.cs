using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 5;
    float lasttimeW;
    float lasttimeS;
    float lasttimeA;
    float lasttimeD;

    public GameObject bullet;
    public float cooldown = 1f;
    float nextfire;
    List<GameObject> bullets = new List<GameObject>();    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if(Time.time > nextfire)
            {
                nextfire = Time.time + cooldown;
                Instantiate(bullet, transform.position, transform.rotation);
                if(Instantiate(bullet, transform.position, transform.rotation))
                {
                    bullets.Add(bullet);
                }
                      
            }
            Debug.Log(bullets.Count);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
            lasttimeW = Time.time;
        if(Input.GetKeyDown(KeyCode.DownArrow))
            lasttimeS = Time.time;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            lasttimeA = Time.time;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            lasttimeD = Time.time;
        
        if(Input.GetKeyUp(KeyCode.UpArrow))
            lasttimeW = 0;
        if(Input.GetKeyUp(KeyCode.DownArrow))
            lasttimeS = 0;
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            lasttimeA = 0;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            lasttimeD = 0;

        if (Input.GetKey(KeyCode.UpArrow) && lasttimeW > lasttimeS)
            transform.position += new Vector3(0, speed) * Time.deltaTime;   
        if (Input.GetKey(KeyCode.DownArrow) && lasttimeS > lasttimeW)
            transform.position += new Vector3(0, -speed) * Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow) && lasttimeA > lasttimeD)
            transform.position += new Vector3(-speed, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow) && lasttimeD > lasttimeA)
            transform.position += new Vector3(speed, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 3;
        else
            speed = 5;
    }
}