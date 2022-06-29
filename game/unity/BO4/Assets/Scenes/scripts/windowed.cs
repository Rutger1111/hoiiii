using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowed : MonoBehaviour
{
    public int screenwidth = Screen.width;
    public int screenHeight = Screen.height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            if (Screen.fullScreen == false)
            {
                Screen.fullScreen = true;
                Screen.SetResolution(1920, 1080, true);
            }

            if (Screen.fullScreen == true)
            {
                Screen.fullScreen = false;
            }
        }
    }
}
