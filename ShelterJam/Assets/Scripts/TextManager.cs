using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public GameManager manager;
    [SerializeField] Text FoodText;
    [SerializeField] Text WaterText;
    [SerializeField] Text HappinessText;
    [SerializeField] Text PopulationText;

    

    
    void Update()
    {
        FoodText.text = " " + manager.Food;
        WaterText.text = " " + manager.Water;
        HappinessText.text = " " + manager.Happiness;
        PopulationText.text = " " + manager.Population;
    }
}
