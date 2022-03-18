using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Text.RegularExpressions;
using Toggle = UnityEngine.UI.Toggle;

public class button : MonoBehaviour
{
    public GameObject yemekToggle, suToggle, mutlulukToggle;
    // Start is called before the first frame update
    void Start()
    {
       yemekToggle = GameObject.Find("yemek");
       suToggle = GameObject.Find("su");
       mutlulukToggle=GameObject.Find("mutluluk");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yemek()
    {
        if (yemekToggle.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("yemek");
        }
        
        
    }
    public void su()
    {
        if (suToggle.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("su");
        }
    }
    public void mutluluk()
    {
        if (mutlulukToggle.GetComponent<Toggle>().isOn == true)
        {
            Debug.Log("mutluluk");
        }
    }
}
