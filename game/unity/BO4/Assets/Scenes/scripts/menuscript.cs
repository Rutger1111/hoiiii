using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public Canvas StartSCreen;
    public Canvas MainCreen;
    public Canvas OptionsCreen;
    // Start is called before the first frame update
    void Start()
    {
        MainCreen.enabled = false;
        OptionsCreen.enabled = false;
        StartSCreen.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void starttoMainButton()
    {
        StartSCreen.enabled = false;
        MainCreen.enabled = true;
    }
    public void maintoOptionsButton()
    {
        MainCreen.enabled = false;
        OptionsCreen.enabled = true;
    }
    public void maintoGame()
    {
        SceneManager.LoadScene("Atoma");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void optionsBackButton()
    {
        OptionsCreen.enabled = false;
        MainCreen.enabled = true;
    }
}
