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
        if(BrawnSugarFactory == null)
        {
            FactoryFlag = false;
        }

        if (CheckChangeMonth())
        {
            GrowUp();
            if (CheckHarvestDay())
            {
                if (FactoryFlag == true && BrawnSugarFactory != null)
                {
                    if (BrawnSugarFactory.tag == ("BrownSugarFactroy"))
                    {
                        BrawnSugarFactory.GetComponent<BrownSugarFactory>().SugarcaneGrowth = ProduceGrowth;
                        Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
                    }

                    else if (BrawnSugarFactory.tag == ("RumFactory"))
                    {
                        BrawnSugarFactory.GetComponent<RumFactory>().SugarcaneGrowth = ProduceGrowth;
                        Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
                    }

                }
                else
                {
                    Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_Sugarcane);

                    Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
                }
            }
        }
    }
}