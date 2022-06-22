using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiWalk : MonoBehaviour
{
    public GameObject ENemy;
    Vector3 onthoud;
    public float minx = -0.1f;
    public float miny = -0.1f;
    public float minz = -0.1f;
    public float maxx = 0.1f;
    public float maxy = 0.1f;
    public float maxz = 0.1f;
    public List<float> x;
    public List<float> y;
    public List<float> z;
    public float minFluxx = -0.1f;
    public float minFluxy = -0.1f;
    public float minFluxz = -0.1f;
    public float maxFluxx = -0.1f;
    public float maxFluxy = -0.1f;
    public float maxFluxz = -0.1f;
    public float speed = 1;
    public int nodig = 0;
    bool ALIVE = true;

    // Start is called before the first frame update
    void Start()
    {
        kijknaar();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(new Vector3(0, 0, 0));
        if(ENemy)
        {
            //transform.LookAt(new Vector3(10,10,10));
            onthoud = transform.eulerAngles;
            if (transform.position.x > minx && transform.position.y > miny && transform.position.z > minz && transform.position.x < maxx && transform.position.y < maxy && transform.position.z < maxz)
            {
                ENemy.transform.eulerAngles = new Vector3(0, 0, 0);
                Verander();
            }
            transport();
        }
    }
    void Verander()
    {

        ENemy.transform.eulerAngles = new Vector3(0, 0, 0);
        minx += x[nodig];
        miny += y[nodig];
        minz += z[nodig];
        maxx += x[nodig];  //errors maak dat als je bij de laatste nodig is dat hij terug gaat naar de eerste nodig gaat
        maxy += y[nodig];
        maxz += z[nodig];
        //Debug.Log(minx + miny + minz);
     
        if(nodig < x.Count - 1)
        {
            nodig++;
        }
        
        kijknaar();
    }
    void transport()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        kijknaar();
    }
    void kijknaar()
    {
        transform.LookAt(new Vector3(minx + (maxx - minx) / 2, miny + (maxy - miny) / 2, 0));
        
        ENemy.transform.eulerAngles = new Vector3(0, 0, 0);
    }

}
