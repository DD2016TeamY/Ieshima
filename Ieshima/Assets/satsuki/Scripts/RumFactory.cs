using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class RumFactry : FactoryClass {
    private int SugarcaneGrowth;    //工場に入ってくるサトウキビ
    private int FermentDays;        //ラムの熟成期間

	// Use this for initialization
	void Start () {
        SugarcaneGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.RumFactoryCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_RumFactory;
	}
	
	// Update is called once per frame
	void Update () {
        SetPower();
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                if (CheckFermentDay())
                {
                    STATIC_SPACE.StaticValue.NationalTreasury += (SugarcaneGrowth * CONSTATIC_SPACE.ConstaticValue.Price_of_Rum * STATIC_SPACE.StaticValue.BrandPower_of_Rum);
                    STATIC_SPACE.StaticValue.BrandPower_of_Rum = SugarcaneGrowth;
                    Reset(CONSTATIC_SPACE.ConstaticValue.BuildingPiliod_of_Rum);
                    PayCost(CONSTATIC_SPACE.ConstaticValue.RumFactoryRunningCost);
                }
                else
                {
                    Ferment();
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
	}

    void OnTriggerEnter(Collider other)
    {
 
    }



    bool CheckFermentDay()
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

    void Reset(int fermentdays)
    {
        FermentDays = fermentdays;
        SugarcaneGrowth = 0;
    }

    void Ferment()
    {
        FermentDays += Random.Range(1, CONSTATIC_SPACE.ConstaticValue.MaximumGrowth);
    }


}
