using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    /*
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, 10))
        {

        }
    }
    */
    Ray ray;
    RaycastHit rayhit;
    public GameObject hoi;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.DrawRay(transform.position, -transform.up);
            Ray ray = new Ray(transform.position, transform.up * 70);
            if (Physics.Raycast(ray, out rayhit))
            {
                print("raycastprintje");
                if (rayhit.transform.gameObject.tag == "enemy")
                {
                    print("raycastprintjeraywerkt");
                    rayhit.transform.gameObject.GetComponent<enemyHealth>().health -= 10;
                    if (rayhit.transform.gameObject.GetComponent<enemyHealth>().health <= 0)
                    {
                        Destroy(rayhit.collider.GetComponent<BoxCollider>());
                        Destroy(rayhit.transform.gameObject);
                    }
                }
            }
        }
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown)
        {
            hallo(time);
        }
    }
    IEnumerator hallo(time)
    {
        WaitForSeconds(time)
    }
    */
}
