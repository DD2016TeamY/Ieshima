using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class RumFactory : FactoryClass
{
    public int SugarcaneGrowth;    //工場に入ってくるサトウキビ
    public int FermentDays;        //ラムの熟成期間
    private int WindFarms;

    // Use this for initialization
    void Start()
    {
        SugarcaneGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.RumFactoryCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_RumFactory;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                GetPower = WindFarms * CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
                SetPower();
                if (CheckFermentDay())
                {
                    if (GetPower >= CONSTATIC_SPACE.ConstaticValue.NeedPower_to_RunRumFactory)
                    {
                        STATIC_SPACE.StaticValue.NationalTreasury += (SugarcaneGrowth * CONSTATIC_SPACE.ConstaticValue.Price_of_Rum * STATIC_SPACE.StaticValue.BrandPower_of_Rum);
                        STATIC_SPACE.StaticValue.BrandPower_of_Rum += 1;
                    }
                    Reset(CONSTATIC_SPACE.ConstaticValue.BuildingPiliod_of_Rum);
                    PayCost(CONSTATIC_SPACE.ConstaticValue.RumFactoryRunningCost);
                }
                else
                {
                    PayCost(CONSTATIC_SPACE.ConstaticValue.RumFactoryRunningCost);
                    if (GetPower >= CONSTATIC_SPACE.ConstaticValue.NeedPower_to_RunRumFactory)
                    {
                        Ferment();
                    }
                }
            }
        }
        else
        {
            if (CheckChangeMonth())
            {
                ConstructionTime--;
                if (ConstructionTime <= 0)
                {
                    ConstructedFlag = true;
                    FermentDays = CONSTATIC_SPACE.ConstaticValue.BuildingPiliod_of_Rum;
                }
            }
        }
        WindFarms = 0;
    }

    bool CheckFermentDay()
    {
        if (SugarcaneGrowth > 0)
        {
            if (--FermentDays < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    void Reset(int fermentdays)
    {
        FermentDays = fermentdays;
        SugarcaneGrowth = 0;
    }

    void Ferment()
    {
        if (SugarcaneGrowth > 0)
        {
            SugarcaneGrowth += Random.Range(1, CONSTATIC_SPACE.ConstaticValue.MaximumGrowth);
        }
    }

    void OnTriggerStay(Collider windfarm)
    {
        if (windfarm.gameObject.tag == "WindFarm")
        {
            WindFarms++;
        }
    }
}
