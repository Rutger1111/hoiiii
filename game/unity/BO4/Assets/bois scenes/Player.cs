using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
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
    public GameObject hallw;
    public GameObject hand;
    public bool shoot;
    bool longroom = false;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        sroom = GameObject.Find("backgroundd");
        roomt2 = GameObject.Find("room2");
        hallw = GameObject.Find("room0");
        float sf = GetComponent<sanity>().sanityfloat = 1;
        GetComponent<sanity>().sanitybar.value = sf; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(longroom == true)
        {
            Camera.main.transform.position = transform.position + new Vector3(0, 1.2f, -10);
        }
            
        foreach (GameObject i in gameitems)
        {
            Vector3 distVector = i.transform.position - transform.position;
            float distance = distVector.magnitude;

            if (distance < 1.5f) //in functions
            {
                if (Input.GetKey(KeyCode.Space) && pickup == false)
                {
                    shoot = true;
                    i.transform.parent = hand.transform;
                    i.transform.position = hand.transform.position;
                    pickup = true;
                }
                if (Input.GetKeyDown(KeyCode.Q) && pickup == true)
                {
                    if (this.transform.childCount > 0)
                    {
                        this.transform.GetChild(0).parent = null;
                    }
                    pickup = false;
                    shoot = false;
                }
            }
        }
        if (kanLopen == true)
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < -1)
            {
                transform.position += new Vector3(0, speed) * Time.deltaTime;
                //transform.localScale -= (new Vector3(speed / 1.4f, speed / Scale2) * Time.deltaTime) / 3;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed, 0) * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -1)
            {
                transform.position -= new Vector3(0, speed) * Time.deltaTime;
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
            longroom = true;
            Camera.main.transform.position = hallw.transform.position + new Vector3(0, 0, -10);
            float sf = GetComponent<sanity>().sanityfloat = Random.Range(0.1f, 1f);
            GetComponent<sanity>().sanitybar.value = sf;
        }
        if(collision.gameObject.name == "door")
        {
            transform.position = new Vector3(hallw.transform.position.x - 13, -1.2f, hallw.transform.position.z);
            longroom = true;
        }
        if (collision.gameObject.name == "door(1)")
        {
            transform.position = new Vector3(sroom.transform.position.x, 2.1f, sroom.transform.position.z);
            Camera.main.transform.position = roomt2.transform.position + new Vector3(0, 0, -10);
        }
        if(collision.gameObject.name == "door(2)")
        {
            transform.position = new Vector3(roomt2.transform.position.x - 13, -1.2f, roomt2.transform.position.z);
        }
    }
    void ChangeSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}
