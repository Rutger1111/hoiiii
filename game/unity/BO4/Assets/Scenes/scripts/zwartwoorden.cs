using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zwartwoorden : MonoBehaviour
{
    [SerializeField] private Image imagie;
    [SerializeField] private float A = 0;
    [SerializeField] private bool amagGaan = false;
    [SerializeField] private float snelheid = 1;
    // Start is called before the first frame update
    void Start()
    {
        imagie = GetComponent<Image>()
;    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            amagGaan = true;
        }
        if (A >= 1.1f)
        {
            amagGaan = false;
        }
        if (amagGaan == true)
        {
            imagie.color = new Vector4(0,0,0,A);
            A += 0.5f * Time.deltaTime / snelheid;
        }
        if (amagGaan == false)
        {
            imagie.color = new Vector4(0, 0, 0, A);
            if (A >= 0)
            {
                A -= 0.5f * Time.deltaTime / snelheid;
            }
            
        }


    }
}
