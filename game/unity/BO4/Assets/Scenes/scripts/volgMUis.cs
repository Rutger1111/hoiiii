using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volgMUis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WorldView = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        WorldView.z = 0f;
        transform.position = WorldView;
        //transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        // transform.position -= new Vector3(270, 104,0);
    }
}
