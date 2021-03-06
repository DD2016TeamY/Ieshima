﻿using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class PurupuruFactory : FactoryClass
{

    public int RedpotatoGrowth; //工場に入ってくる紅イモ

    // Use this for initialization
    void Start()
    {
        RedpotatoGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.PurupuruFactoryCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_PurupuruFactory;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                STATIC_SPACE.StaticValue.NationalTreasury += (RedpotatoGrowth * CONSTATIC_SPACE.ConstaticValue.Price_of_Purupuru);
                RedpotatoGrowth = 0;
                PayCost(CONSTATIC_SPACE.ConstaticValue.PuruPuruFactoryRunningCost);
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
    }
}
