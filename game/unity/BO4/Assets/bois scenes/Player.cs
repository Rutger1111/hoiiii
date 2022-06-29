using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    public float Scale1 = 4f;
    public float Scale2 = 1f;
    
    public List<GameObject> gameitems;
    public List<GameObject> holding;

    public SpriteRenderer spriteRenderer;
    public Sprite sprite;

    bool keycard = false;
    bool longroom = false;
    public bool kanLopen = true;
    public bool shoot;
    public bool pickup;
    bool hallbool = false;
    bool muur = false;

    public GameObject sroom;
    public GameObject roomt2;
    public GameObject hallw;
    public GameObject room3;
    private GameObject keycardobj;
    public GameObject keyroom;

    public GameObject hand;
    public GameObject een;
    public GameObject twee;
    public GameObject drie;
    public GameObject opvolger;

    public GameObject endButton;
    // Start is called before the first frame update
    void Start()
    {
        keycardobj = GameObject.Find("keycard");
        sroom = GameObject.Find("backgroundd");
        roomt2 = GameObject.Find("room2");
        hallw = GameObject.Find("room0");
        keyroom = GameObject.Find("keyroom");
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
                    i.transform.eulerAngles = new Vector3(0,0,0);
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

            if (Input.GetKey(KeyCode.W) && hallbool == false && transform.position.y < 0)
            {
                transform.position += new Vector3(0, speed) * Time.deltaTime;
                //transform.localScale -= (new Vector3(speed / 1.4f, speed / Scale2) * Time.deltaTime) / 3;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed, 0) * Time.deltaTime;
                spriteRenderer.flipX = true;

            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -1.3f)
            {
                transform.position -= new Vector3(0, speed) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed, 0) * Time.deltaTime;
                spriteRenderer.flipX = false;
            }
            if(transform.position.x > 8 && transform.position.x < 12)
            {
                GetComponent<sanity>().sanityfloat = 0.4f;
            }
        }
        if (transform.position.x - endButton.transform.position.x <= 1 && transform.position.x - endButton.transform.position.x >= -1 && transform.position.y >= 15)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(0);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "CommandRoom")
        {
            longroom = false;
            Camera.main.transform.position = collision.transform.position - new Vector3(0, 0, 10);
        }
        if (collision.gameObject.name == "room2")
        {
            float sf = GetComponent<sanity>().sanityfloat = Random.Range(0.1f, 1f);
            GetComponent<sanity>().sanitybar.value = sf;
        }
        if(collision.gameObject.name == "backgroundd")
        {
            longroom = false;
        }
        if(collision.gameObject.name == "room0")
        {
            hallbool = true;
            longroom = true;
            Camera.main.transform.position = hallw.transform.position + new Vector3(0, -2, -10);
            float sf = GetComponent<sanity>().sanityfloat = 0.5f;
            GetComponent<sanity>().sanitybar.value = sf;
        }
        else
            hallbool=false;
        if(collision.gameObject.name == "door")
        {
            transform.position = new Vector3(hallw.transform.position.x - 13, -1.2f, hallw.transform.position.z);
            longroom = true;
        }
        if(collision.gameObject.name == "door2")
        {
            transform.position = new Vector3(roomt2.transform.position.x - 13, -1.2f, roomt2.transform.position.z);
        }
        if(collision.gameObject.name == "keydoorsprite" && keycard == true)
        {
            transform.position = room3.transform.position;
        }
        if(collision.gameObject.name == "door4")
        {
            longroom = false;
            transform.position = keyroom.transform.position - new Vector3(0, 1, 0);
            Camera.main.transform.position = keyroom.transform.position - new Vector3(0, 0, 10);
        }
        if(collision.gameObject.name == "door5")
        {
            transform.position = roomt2.transform.position - new Vector3(-8, 1, 0);
            Camera.main.transform.position = transform.position - new Vector3(0, 0, 10);
            longroom = true;
        }
        if(collision.gameObject.name == "keycard")
        {
            keycard = true;
            Destroy(keycardobj);
        }

    }
    void ChangeSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}
