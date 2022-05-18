using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float Scale1 = 4f;
    public float Scale2 = 1f;
    public bool kanLopen = true;
    public GameObject opvolger;
    public List<GameObject> gameitems;
    public int[] gameitemsarray = new int[] {};
    public float deurBound1x;
    public float deurBound1y;
    public float deurBound1z;

    public float deurBound2x;
    public float deurBound2y;
    public float deurBound2z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (kanLopen == true)
        {
            if (transform.position.x >= deurBound1x && transform.position.x <= deurBound2x)
            {

            }
            if (Input.GetKey(KeyCode.W) && transform.position.y < -3)
            {
                transform.position += new Vector3(0, speed) * Time.deltaTime;
                transform.localScale -= (new Vector3(speed / Scale1, speed / Scale2) * Time.deltaTime) /3;
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x > -6.5)
            {
                transform.position -= new Vector3(speed, 0) * Time.deltaTime;   
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -5)
            {
                transform.position -= new Vector3(0, speed) * Time.deltaTime;
                transform.localScale += (new Vector3(speed / 1.4f, speed) * Time.deltaTime) /3;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 5)
            {
                transform.position += new Vector3(speed, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Space))
            {
            
            }
        }
    }
}
