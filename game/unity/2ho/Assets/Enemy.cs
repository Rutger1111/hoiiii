using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    public List<GameObject> waypoints = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            transform.position +=  (waypoints[i] - transform.position) * speed * Time.deltaTime;
        }
    }
}
