using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPath : MonoBehaviour
{
    public List<Vector3> points;
    public static int lookAT = 0;
    [SerializeField] private Vector3 distance;
    [SerializeField] private float rotationX;
    [SerializeField] private float rotationY;
    [SerializeField] private float rotationZ;
    [SerializeField] private GameObject AngleObject;
    [SerializeField] private bool GO = true;
    [SerializeField] private Vector3 Voor;
    [SerializeField] private Vector3 Na;

    // Start is called before the first frame update
    void Start()
    {
        Voor = transform.position;
        //transform.LookAt(points[lookAT]);
       // distance = points[lookAT] - transform.position;
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
        float hoek = AngleObject.GetComponent<kijknaar>().angle;
        transform.position += new Vector3(Mathf.Cos(hoek), Mathf.Sin(hoek), 0);
        
        //float sin = Mathf.Sin(hoek / 100);
        //print(sin * 2);
        //float tan = Mathf.Tan(hoek / 100);
        //print("tan" + sin * 2 / tan);
        // transform.position = new Vector3(sin * 2 / tan, sin * 2, 0);
        //transform.position += distance * Time.deltaTime / 3;
        //transform.position += new Vector3(sin * 2 / tan * 200, sin * 2 * 200, 0);
    }
}
