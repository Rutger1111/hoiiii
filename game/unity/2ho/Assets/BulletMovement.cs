using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector3 targetDir;
    public float speed;
    public int distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += targetDir * 1 / 60 * speed;
        if (transform.position.y > 10)
            Destroy(gameObject);
    }
}
