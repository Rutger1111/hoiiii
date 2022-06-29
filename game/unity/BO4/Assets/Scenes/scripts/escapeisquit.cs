using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escapeisquit : MonoBehaviour
{
    public bool isQuiting = false;
    public bool latenZien = false;
    public int secondCount = 5;
    public int meerdereKeren = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isQuiting = false;
            secondCount = 5;
            text.enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            isQuiting = true;
            if (meerdereKeren == 0)
            {
                meerdereKeren++;
                StartCoroutine(countdown());
            }
            
            text.enabled = true;
        }

        text.text = "" + secondCount;
    }
    IEnumerator countdown()
    {
        latenZien = true;
        yield return new WaitForSeconds(1);
        if(isQuiting == false && meerdereKeren <= 1)
        {
            meerdereKeren = 0;
        }

        if(isQuiting == true)
        {
            secondCount--;
        }
        
        if (isQuiting == true)
        {
            StartCoroutine(countdown());
        }

        if (isQuiting == true && secondCount == 0)
        {
            Application.Quit();
        }
    }
}
