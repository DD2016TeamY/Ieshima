﻿using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;


public class Redpotatoes : FarmClass
{
    public GameObject PurupuruFactory;
     protected int RedPotatoGrowth;
    // Use this for initialization
    void Start()
    {
        HarvestDays = CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_RedPotato;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckChangeMonth())
        {
            if(PurupuruFactory == null)
            {
                FactoryFlag = false;
                this.gameObject.GetComponent<LinkPurupuru>().LinkFlag = false;
            }

            GrowUp();

            if (CheckHarvestDay())
            {
                if (FactoryFlag == true)
                {
                    PurupuruFactory.GetComponent<PurupuruFactory>().RedpotatoGrowth = ProduceGrowth;
                    Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_RedPotato);
                }
                else
                {
                    Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_RedPotato);
                    Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_RedPotato);
                }
            }
        }
    }
}
