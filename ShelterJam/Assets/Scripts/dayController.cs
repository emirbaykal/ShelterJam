using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayController : MonoBehaviour
{
    public int gunSayac,aySayac, yilSayac;
    public Text takvim;
    public GameManager gameManager;

    public GameObject foodToggle, waterToggle, happnessToggle, killToggle;

    // Start is called before the first frame update
    void Start()
    {
        
        
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

    public void nnextDay()
    {
        if (killToggle.GetComponent<Toggle>().isOn == false && foodToggle.GetComponent<Toggle>().isOn == false && waterToggle.GetComponent<Toggle>().isOn == false && happnessToggle.GetComponent<Toggle>().isOn == false)
        {
            gameManager.NextDay();
        }

        if (foodToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.FoodSearch();
            foodToggle.GetComponent<Toggle>().isOn = false;
        }
        if (waterToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.WaterSearch();
            waterToggle.GetComponent<Toggle>().isOn = false;
        }
        if (happnessToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.FreeTime();
            happnessToggle.GetComponent<Toggle>().isOn = false;
        }
        if (killToggle.GetComponent<Toggle>().isOn == true)
        {
            gameManager.KillPopulation();
            killToggle.GetComponent<Toggle>().isOn = false;
        }
       

        gameManager.PopulationUpdate();
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
