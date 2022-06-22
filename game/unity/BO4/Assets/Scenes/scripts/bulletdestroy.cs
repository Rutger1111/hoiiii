using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 10)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
