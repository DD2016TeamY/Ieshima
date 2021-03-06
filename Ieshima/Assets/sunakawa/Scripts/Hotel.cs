﻿using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Hotel : FactoryClass
{
    private int WindFarms;

    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.HotelCost);

        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_Hotel;

        STATIC_SPACE.StaticValue.TourismNumber_of_Facilities += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth()/* && GetPower > CONSTATIC_SPACE.ConstaticValue.NeedPower_to_RunHotel*/)
            {
                GetPower = WindFarms * CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
                SetPower();
                if (GetPower >= CONSTATIC_SPACE.ConstaticValue.NeedPower_to_RunHotel)
                {
                    Gain();
                }
                PayCost(CONSTATIC_SPACE.ConstaticValue.HotelRunningCost);
            }
        }
        else if (CheckChangeMonth())
        {
            ConstructionTime -= 1;

            if (ConstructionTime <= 0)
            {

                ConstructedFlag = true;

            }
        }

        WindFarms = 0;
    }

    void Gain()
    {
        STATIC_SPACE.StaticValue.NationalTreasury += (int)(STATIC_SPACE.StaticValue.TourismNumber_of_Facilities * STATIC_SPACE.StaticValue.Tourists *
                                                    (STATIC_SPACE.StaticValue.EventsScale + 1));
    }

    void OnTriggerStay(Collider windfarm)
    {
        if (windfarm.gameObject.tag == "WindFarm")
        {
            WindFarms++;
        }
    }
}