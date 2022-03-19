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
    //
    public int PopulationDecrease;
    public int PopulationIncrease;

    public void FoodSearch()
    {
        Food += FoodIncraese;
        Water -= WaterDecrease;
        Happiness -= HappinessDecrease;
        int rand = Random.Range(0, 100);
        if (rand <= 25)
        {
            Population -= PopulationDecrease;
        }
    }
    public void WaterSearch()
    {
        int rand = Random.Range(0, 100);
        if (rand <= 25)
        {
            Population -= PopulationDecrease;
        }
        Food -= FoodDecrease;
        Water += WaterIncrease;
        Happiness -= HappinessDecrease;

    }
   public void KillPopulation()
    {
        Population -= PopulationDecrease;
        Food -= FoodDecrease;
        Water -= WaterDecrease;
        Happiness -= HappinessDecrease;

    }
    public void FreeTime()
    {
        Food -= FoodDecrease;
        Water -= WaterDecrease;
        Happiness += HappinessIncrease;

    }
}
