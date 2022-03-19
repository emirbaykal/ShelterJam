using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayController : MonoBehaviour
{
    private int gunSayac,aySayac, yilSayac;
    public Text takvim;
    public GameManager gameManager;

    public GameObject foodToggle, waterToggle, happnessToggle, killToggle;

    // Start is called before the first frame update
    void Start()
    {
        
         foodToggle = GameObject.Find("Food");
       waterToggle = GameObject.Find("Water");
       happnessToggle=GameObject.Find("Free Time");
       killToggle=GameObject.Find("Kill");
        
        
        ////////////////////////////
        gunSayac = 1;
        aySayac = 11;
        yilSayac = 1;
        takvim.text = yilSayac + ". yil   " + aySayac + ". ay   "+ gunSayac+".gun   ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextDay()
    {

        if (foodToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.FoodSearch();
        }
        if (waterToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.WaterSearch();
        }
        if (happnessToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.FreeTime();
        }
        if (killToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.KillPopulation();
        }

        ////////////////////////////////////////
        gunSayac++;
        if (gunSayac == 31)
        {
            gunSayac = 1;
            aySayac++;
        }
        if (aySayac == 13)
        {
            aySayac = 1;
            yilSayac++;
        }

        takvim.text = yilSayac + ". yil   " + aySayac + ". ay   "+ gunSayac+".gun   ";
        
    }
}
