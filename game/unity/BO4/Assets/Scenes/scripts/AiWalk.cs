using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiWalk : MonoBehaviour
{
    public float speed = 0.5f;
    public List<Vector3> wp = new List<Vector3>();
    int i;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (wp[i] - transform.position).normalized * Time.deltaTime * speed;
        if (Vector3.Distance(transform.position, wp[i]) < 1)
        {
            i++;
            if (i == wp.Count)
                i = 0;
        }
    }
}