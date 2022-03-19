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

  
    private void Update()
    {
        
        FoodDecrease = (int)(-0.055f * ((Population - 31.5) * (Population - 31.5)) + 30);
        WaterIncrease = (int)(-0.1f* ((Population - 29  ) * (Population - 29)) + 31);

    }
    public void FoodSearch()
    {
        //(FoodIncraese - FoodDecrease)
        Food +=  FoodDecrease;
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
        Food -= Population * 6 / 10;
        Water += WaterIncrease;
        Happiness -= HappinessDecrease;
        int rand = Random.Range(0, 100);
        if (rand <= 8)
        {
            Population -= Population * 3 / 100;
        }
        
        

    }
    public void KillPopulation()
    {
        Population -= PopulationDecrease;
        Food -= Population * 6 / 10;
        Water -= Population * 8 / 10;
        Happiness -= HappinessKill;

    }
    public void FreeTime()
    {
        Food -= Population * 6 / 10;
        Water -= Population * 8 / 10;
        Happiness += HappinessIncrease;
        Population += PopulationIncrease;
    }
    public void NextDay()
    {
        Debug.Log(31);
        Food -= Population*6/10;
        Water -= Population * 8 / 10;
        Happiness += HappinessIncrease / 3;

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
    public void Parabola()
    {

        Debug.Log((int)(-0.00765f * ((Population - 100) * (Population - 100)) + 70));
        Food += (int)(-0.00765f * ((Population - 100) * (Population - 100)) + 70);



    }

}