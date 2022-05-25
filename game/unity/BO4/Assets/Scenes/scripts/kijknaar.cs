using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kijknaar : MonoBehaviour
{
    [SerializeField] private GameObject bekijkt;
    [SerializeField] private GameObject vanuit;
    [SerializeField] private Vector3 rotatie;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private GameObject kijkobject = null;
    [SerializeField] private Text textie;
    public float angle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = bekijkt.transform.position.x - transform.position.x;
        float y = bekijkt.transform.position.y - transform.position.y;
        float ab = vanuit.transform.position.x - x;
        float bc = vanuit.transform.position.y - y;
        float a = bc / ab;
       
        print("hoi" + a);
        
        print(ab);
        print(bc);
        angle = Mathf.Atan2(bc,ab)*Mathf.Rad2Deg;
        
        print("hoi 1 4"+ a * Mathf.PI);
        float aaaa = angle;
        textie.text = ("" + aaaa);
        /*
        if (aaaa >= -60 && aaaa <= 0)
        {

            
            gameObject.transform.eulerAngles = new Vector3(0,0,90); 
            
            
        }
        if (aaaa >= -120 && aaaa <= -60)
        {
            

            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);


        }
        if (aaaa >= -180 && aaaa <= -120)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, -90);
        }
        */
        gameObject.transform.eulerAngles = new Vector3(0, 0, angle + 90);
        //transform.LookAt(bekijkt.transform);


        /*
        kijkobject.transform.LookAt(bekijkt.transform);
        if (kijkobject.transform.localEulerAngles.x <= 30 && kijkobject.transform.localEulerAngles.x >= -30)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        */
    }
}
