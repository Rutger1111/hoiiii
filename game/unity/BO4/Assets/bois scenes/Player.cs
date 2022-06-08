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
    public List<GameObject> holding;
    public bool pickup;
    public GameObject een;
    public GameObject twee;
    public GameObject drie;
    public GameObject sroom;
    public GameObject roomt2;
    public GameObject room0;

    // Start is called before the first frame update
    void Start()
    {
        sroom = GameObject.Find("backgroundd");
        roomt2 = GameObject.Find("room2");
        room0 = GameObject.Find("room0");
}

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(7, 5, 0), new Vector3(7, -5, 0), Color.red);
        foreach (GameObject i in gameitems)
        {
            Vector3 distVector = i.transform.position - transform.position;
            float distance = distVector.magnitude;

            if (distance < 1.5f)
            {
                if (Input.GetKey(KeyCode.Space) && pickup == false)
                {
                    i.transform.parent = transform;
                    i.transform.position = transform.position;
                    pickup = true;
                }
                if (Input.GetKeyDown(KeyCode.Q) && pickup == true)
                {
                    if (this.transform.childCount > 0)
                    {
                        this.transform.GetChild(0).parent = null;
                    }
                    pickup = false;
                }
            }
        }
        if (kanLopen == true)
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < -3)
            {
                transform.position += new Vector3(0, speed) * Time.deltaTime;
                transform.localScale -= (new Vector3(speed / 1.4f, speed / Scale2) * Time.deltaTime) / 3;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -5)
            {
                transform.position -= new Vector3(0, speed) * Time.deltaTime;
                transform.localScale += (new Vector3(speed / 1.4f, speed) * Time.deltaTime) / 3;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed, 0) * Time.deltaTime;
            }
            if(transform.position.x > 8 && transform.position.x < 12)
            {
                GetComponent<sanity>().sanityfloat = 0.4f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "room2")
        {
            float sf = GetComponent<sanity>().sanityfloat = Random.Range(0.1f, 1f);
            GetComponent<sanity>().sanitybar.value = sf;
        }
        if(collision.gameObject.name == "backgroundd")
        {

        }
        if(collision.gameObject.name == "room0")
        {
            Camera.main.transform.position = room0.transform.position + new Vector3(0, 0, -10);
            float sf = GetComponent<sanity>().sanityfloat = Random.Range(0.1f, 1f);
            GetComponent<sanity>().sanitybar.value = sf;
        }
        if(collision.gameObject.name == "door")
        {
            Debug.Log("door");
            transform.position = roomt2.transform.position - new Vector3(0, 3);
            Camera.main.transform.position = roomt2.transform.position + new Vector3(0, 0, -10);
        }
    }
}
