using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class TobaccoFactory : FactoryClass
{

    public int TobaccoGrowth; //工場に入ってくるタバコ
    private int WindFarms;


    // Use this for initialization
    void Start()
    {
        TobaccoGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.TobaccoFactoryCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_TobaccoFactory;
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
                if (GetPower >= CONSTATIC_SPACE.ConstaticValue.NeedPower_to_RunTobaccoFactory)
                {
                    STATIC_SPACE.StaticValue.NationalTreasury += (TobaccoGrowth * CONSTATIC_SPACE.ConstaticValue.Price_of_Tobacco);
                }
                TobaccoGrowth = 0;
                PayCost(CONSTATIC_SPACE.ConstaticValue.TobaccoFactoryRunningCost);
            }
        }
        else
        {
            if (CheckChangeMonth())
            {
                DecreaseConstructionTime();
                if (ConstructionTime <= 0)
                {
                    ConstructedFlag = true;
                }
            }
        }
        WindFarms = 0;
    }

    void OnTriggerStay(Collider windfarm)
    {
        if (windfarm.gameObject.tag == "WindFarm")
        {
            WindFarms++;
        }
    }
}
