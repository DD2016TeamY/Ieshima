using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Riripark : FactoryClass
{

    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.LilyGardenParkCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_LilyGardenPark;
        STATIC_SPACE.StaticValue.TourismNumber_of_Facilities += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                Gain();
                PayCost(CONSTATIC_SPACE.ConstaticValue.LilyGardenParkRunningCost);

            }
        }else if(CheckChangeMonth())
        {
            ConstructionTime -= 1;
            if(ConstructionTime <= 0)
            {
                ConstructedFlag = true;
            }
        }

    }

    void Gain()
    {
        if ((STATIC_SPACE.StaticValue.Month / 12) == 5)
        {
            STATIC_SPACE.StaticValue.NationalTreasury = STATIC_SPACE.StaticValue.TourismNumber_of_Facilities * STATIC_SPACE.StaticValue.Tourists;
        }
        else {
            STATIC_SPACE.StaticValue.NationalTreasury = STATIC_SPACE.StaticValue.TourismNumber_of_Facilities * STATIC_SPACE.StaticValue.Tourists * (STATIC_SPACE.StaticValue.EventsScale + 1);
        }
    }
}
