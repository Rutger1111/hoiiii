using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kijnaardeMUis : MonoBehaviour
{
    [SerializeField] private GameObject bekijkt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(bekijkt.transform);
        gameObject.transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }
}
