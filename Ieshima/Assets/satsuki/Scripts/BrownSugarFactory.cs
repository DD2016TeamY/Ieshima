using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class BrownSugarFactory : FactoryClass {

    private int SugarcaneGrowth; //工場に入ってくるサトウキビ 

	// Use this for initialization
	void Start () {
        SugarcaneGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.BrownSugarFactoryCost);
        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_BrownSugarFactory;
	}
	
	// Update is called once per frame
	void Update () {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                STATIC_SPACE.StaticValue.NationalTreasury += SugarcaneGrowth;
                SugarcaneGrowth = 0;
                STATIC_SPACE.StaticValue.NationalTreasury -= CONSTATIC_SPACE.ConstaticValue.BrownSugarFactoryRunningCost;
            }
        }
        else 
        {
            if (CheckChangeMonth())
            {
                --ConstructionTime;
                if (ConstructionTime <= 0)
                {
                    ConstructedFlag = true;
                }
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
         //Br= this.gameObject;
    }



}
