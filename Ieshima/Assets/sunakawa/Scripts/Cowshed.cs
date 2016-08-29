using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Cowshed : FarmClass
{

    // Use this for initialization
    void Start()
    {
        HarvestDays = CONSTATIC_SPACE.ConstaticValue.RearingDays_of_Cow;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckChangeMonth())
        {
            GrowUp();
            if (CheckHarvestDay())
            {
                Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_cow, STATIC_SPACE.StaticValue.BrandPower_of_Cow);
               
                if (ProduceGrowth > STATIC_SPACE.StaticValue.BrandPower_of_Cow)
                {
                    Reset(CONSTATIC_SPACE.ConstaticValue.Price_of_cow);
                }
            }
        }
    }
}
