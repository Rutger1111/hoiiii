using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deSanityBar : MonoBehaviour
{
    public Slider slidei;
    public int health = 100;
    public GameObject companian;
    // Start is called before the first frame update
    void Start()
    {
        slidei = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        slidei.value = companian.GetComponent<enemyHealth>().health;
    }
}
