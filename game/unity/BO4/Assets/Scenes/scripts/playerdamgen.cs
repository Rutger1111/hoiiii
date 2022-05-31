using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdamgen : MonoBehaviour
{
    public GameObject hart1;
    public GameObject hart2;
    public GameObject hart3;
    public bool raaktPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hart3.active == false)
        {
            StartCoroutine(ietsweg(1));
        }
    }
    IEnumerator ietsweg(float time)
    {
        if (hart3.active == false)
        {
            SceneManager.LoadScene(0);
        }
        if (hart2.active == false)
        {
            hart3.SetActive(false);
            yield return new WaitForSeconds(time);
            if (raaktPlayer == true)
            {
                StartCoroutine(ietsweg(1));
            }
        }
        if (hart1.active == false)
        {
            hart2.SetActive(false);
            yield return new WaitForSeconds(time);
            if (raaktPlayer == true)
            {
                StartCoroutine(ietsweg(1));
            }
        }
        if (hart1.active == true)
        {
            hart1.SetActive(false);
            yield return new WaitForSeconds(time);
            if (raaktPlayer == true)
            {
                StartCoroutine(ietsweg(1));
            }
        }


        yield return new WaitForSeconds(time);

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {
            raaktPlayer = true;
            StartCoroutine(ietsweg(1));
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {
            raaktPlayer = false;
           
        }
    }
}
