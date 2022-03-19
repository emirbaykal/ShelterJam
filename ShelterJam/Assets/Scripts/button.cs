using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Text.RegularExpressions;
using Toggle = UnityEngine.UI.Toggle;

public class button : MonoBehaviour
{
    public GameObject foodToggle, waterToggle, happnessToggle,killToggle;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
       
       foodToggle = GameObject.Find("Food");
       waterToggle = GameObject.Find("Water");
       happnessToggle=GameObject.Find("Free Time");
       killToggle=GameObject.Find("Kill");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Food()
    {
        if (foodToggle.GetComponent<Toggle>().isOn == true)
        {
            
            Debug.Log("yemek");
        } 
    }
    public void Water()
    {
        if (waterToggle.GetComponent<Toggle>().isOn == true)
        {
           // gameManager.WaterSearch();
            Debug.Log("su");
        }
    }
    public void Happness()
    {
        if (happnessToggle.GetComponent<Toggle>().isOn == true)
        {
           // gameManager.FreeTime();
            Debug.Log("mutluluk");
        }
    }
    public void Kill()
    {
        if (killToggle.GetComponent<Toggle>().isOn == true)
        {
           // gameManager.KillPopulation();
            Debug.Log("ölüm");
        }
    }



}
