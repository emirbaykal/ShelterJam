using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void start()
    {
        
    }

    public void option()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void back()
    {
        optionMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void sesKapat()
    {
        AudioListener.volume = 0;
    }
    public void sesAc()
    {
        AudioListener.volume = 1;
    }
}
