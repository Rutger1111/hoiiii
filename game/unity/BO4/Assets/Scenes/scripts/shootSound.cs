using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSound : MonoBehaviour
{
    public GameObject shoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject Sound = Instantiate(shoot);
            Destroy(Sound, 3);
        }
    }
}
