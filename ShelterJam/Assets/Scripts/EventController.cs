using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventController : MonoBehaviour
{
    [SerializeField] Toggle LeftToggle, RightToggle;
    [SerializeField] GameObject EventCard;// ,LeftChoice, RightChoice;
    [SerializeField] Text leftText, rightText, EventText;

    [SerializeField] GameManager manager;

    bool isEvent;

    public int EventNumber;
    void Start()
    {
          
    }
    public void Left()
    {
        switch (EventNumber)
        {
            case 0:
                Debug.Log(0);
                manager.Food += manager.FoodDecrease;
                manager.Water -= manager.WaterIncrease;
                EventCard.SetActive(false);

                break;
            case 1:
                Debug.Log(1);
                break;
            case 2:
                Debug.Log(2);
                break;
            case 3:
                Debug.Log(3);
                break;
            case 4:
                Debug.Log(4);
                break;
        }
        LeftToggle.isOn = false;
        
    }
    public void Right()
    {
        switch (EventNumber)
        {
            case 0:
                Debug.Log(0);
                manager.Food += manager.FoodDecrease;
                manager.Water -= manager.WaterIncrease;
                EventCard.SetActive(false);

                break;
            case 1:
                Debug.Log(1);
                break;
            case 2:
                Debug.Log(2);
                break;
            case 3:
                Debug.Log(3);
                break;
            case 4:
                Debug.Log(4);
                break;
        }
        RightToggle.isOn = false;

    }
    public void EventChoose()
    {
        EventNumber = Random.Range(0, 5);
        switch (EventNumber)
        {
            case 0:
                EventText.text = "1";
                leftText.text = "asd";
                rightText.text = "amk";
                break;
            case 1:
                EventText.text = "2";
                leftText.text = "aq";
                rightText.text = "amk";
                break;
            case 2:
                EventText.text = "3";
                leftText.text = "aq";
                rightText.text = "amk";
                break;
            case 3:
                EventText.text = "4";
                leftText.text = "aq";
                rightText.text = "amk";
                break;
            case 4:
                EventText.text = "5";
                leftText.text = "aq";
                rightText.text = "amk";
                break;
        }
    }
    public void isEventDay()
    {
        EventChoose();
        Debug.Log(31);
       int x = Random.Range(0,4);
        if (x == 2)
        {
            EventCard.SetActive(true);
        }
        else
        {
            EventCard.SetActive(false);
        }
    }
    
    void Update()
    {
        //EventChoose();
    }
}
