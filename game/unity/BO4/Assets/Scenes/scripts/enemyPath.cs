using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPath : MonoBehaviour
{
    [SerializeField] private List<Vector3> points;
    [SerializeField] private int lookAT = -1;
    [SerializeField] private Vector3 distance;
    [SerializeField] private float rotationX;
    [SerializeField] private float rotationY;
    [SerializeField] private float rotationZ;
    [SerializeField] private bool GO = true;
    [SerializeField] private Vector3 Voor;
    [SerializeField] private Vector3 Na;

    // Start is called before the first frame update
    void Start()
    {
        Voor = transform.position;
        //transform.LookAt(points[lookAT]);
        distance = points[lookAT] - transform.position;
        rotationX = transform.rotation.x;
        rotationY = transform.rotation.y;
        rotationZ = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (points[lookAT].x + distance.x >= 0)
        {
            if (transform.position.x >= Voor.x + distance.x)
            {
                lookAT += 1;
                distance = points[lookAT] - transform.position;
                rotationX = transform.rotation.x;
                rotationY = transform.rotation.y;
                rotationZ = transform.rotation.z;
                //transform.LookAt(points[lookAT]);
                Voor = transform.position;
            }
        }
        else
        {
            if (transform.position.x! <= Voor.x + distance.x)
            {
                lookAT += 1;
                distance = points[lookAT] - transform.position;
                rotationX = transform.rotation.x;
                rotationY = transform.rotation.y;
                rotationZ = transform.rotation.z;
                //transform.LookAt(points[lookAT]);
                Voor = transform.position;
            }
        }
        transform.position += distance * Time.deltaTime / 3;
    }
}
