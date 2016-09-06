using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
public class sugarcane : FarmClass
{
    public GameObject BrawnSugarFactory;
    protected int MonthChangeCheck;
    // Use this for initialization
    void Start()
    {
        HarvestDays = CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane;
        MonthChangeCheck = STATIC_SPACE.StaticValue.Month;
    }

    // Update is called once per frame
    void Update()
    {
        if (STATIC_SPACE.StaticValue.Month == MonthChangeCheck)
        {
            GrowUp();
        }
        if (CheckHarvestDay())
        {
        }
        if (FactoryFlag == true)
        {
            if(BrawnSugarFactory.tag == ("BrownSugarFactory")){
                BrawnSugarFactory.GetComponent<BrownSugarFactory>().SugarcaneGrowth = ProduceGrowth;
        }
     }
        else if (BrawnSugarFactory.tag == ("RumFactory")){
        BrawnSugarFactory.GetComponent<RumFactory>().SugarcaneGrowth = ProduceGrowth;
        }        
        else 
        {
            Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_Sugarcane);

            Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
        }
    }