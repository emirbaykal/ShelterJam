using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Variables")]
    public int Food;
    public int Water;
    public int Happiness;
    public int Population;

    [Header("Values")]
    public int FoodDecrease;
    public int FoodIncraese;
    //
    public int WaterDecrease;
    public int WaterIncrease;
    //
    public int HappinessIncrease;
    public int HappinessDecrease;
    [SerializeField] int HappinessKill;
    //
    public int PopulationDecrease;
    [SerializeField] int PopulationIncrease;


    public dayController Day;

  private void FoodUpdate()
    {
        

        if (Happiness >= 70)
        {
            Food += FoodDecrease + Population* 2 / 10;
        }
        else if (Happiness <= 25)
        {
            Food += FoodDecrease - Population * 2 / 10;

        }
        else
        {
            Food += FoodDecrease;
        }
    }

    private void WaterUpdate()
    {
        if (Happiness >= 70)
        {
            Water +=WaterIncrease + Population* 2 / 10;
        }
        else if (Happiness <= 25)
        {
            Water += WaterIncrease - Population * 2 / 10;

        }
        else
        {
            Water += WaterIncrease;
        }
    }
    private void Update()
    {

        FoodDecrease = (int)(-0.055f * ((Population - 31.5) * (Population - 31.5)) + 30);
        WaterIncrease = (int)(-0.1f * ((Population - 29) * (Population - 29)) + 31);
        if (Food <=0)
        {
            Food = 0;
        }
        if (Water <= 0)
        {
            Water = 0;
        }
        if (Food >= 100)
        {
            Food = 100;
        }
        if (Water >= 100)
        {
            Water = 100;
        }
        if (Happiness <=0)
        {
            Happiness = 0;
        }
        if (Population <= 0)
        {
            Population = 0;
        }
        if (Population <= 10)
        {
            FoodDecrease = 4;
        }
        if (Population <= 12)
        {
            WaterIncrease = 4;
        }
        

    }

    public void HappinessCheck()
    {

        if (Food == 0 || Water == 0)
        {
            Debug.Log(69);
            Happiness -= HappinessDecrease + HappinessDecrease * 4 / 10;
        }

        if (Water == 0 && Food == 0)
        {
            Debug.Log(31);
            Happiness -= HappinessDecrease + HappinessDecrease * 6 / 10;
        }


    }
    public void FoodSearch()
    {
        //(FoodIncraese - FoodDecrease)
        HappinessCheck();
        FoodUpdate();
        Water -= Population*8/10;
        Happiness -= HappinessDecrease;
        int rand = Random.Range(0, 100);
        if (rand <= 25)
        {
            Population -= Population * 3 / 100;
        }
    }
    public void WaterSearch()
    {
        HappinessCheck();
        Happiness -= HappinessDecrease;
        Food -= Population * 6 / 10;
        WaterUpdate();

       
        int rand = Random.Range(0, 100);
        if (rand <= 8)
        {
            Population -= Population * 3 / 100;
        }
       
    }
    public void KillPopulation()
    {
        HappinessCheck();
        Population -= PopulationDecrease;
        Food -= Population * 6 / 10;
        Water -= Population * 8 / 10;
        Happiness -= HappinessKill*3/2;

    }
    public void FreeTime()
    {
        HappinessCheck();
        Food -= Population * 6 / 10;
        Water -= Population * 8 / 10;
        Happiness += HappinessIncrease;
        Population += PopulationIncrease;
    }
    public void NextDay()
    {
        HappinessCheck();
       /* Debug.Log(31);
        Food -= Population*6/10;
        Water -= Population * 8 / 10;
        Happiness += HappinessIncrease / 3;
       */
        

    }
    public void PopulationUpdate()
    {

        int x;
        if (Day.gunSayac % 3 == 0)
        {
            x = Population / 15;
            Population += x;
        }
    }

    
}