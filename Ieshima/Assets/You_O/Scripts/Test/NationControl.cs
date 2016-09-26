using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class NationControl : BaseClass {	
	// Update is called once per frame
	void LateUpdate () {
        if(CheckChangeMonth())
        {
            STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Add(STATIC_SPACE.StaticValue.NationalTreasury);
            if (STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 1] - STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 2] > 0)
            {
                STATIC_SPACE.StaticValue.Population = (int)((float)STATIC_SPACE.StaticValue.Population + (float)(STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 1] - STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 2]) * CONSTATIC_SPACE.ConstaticValue.NationScale);
                STATIC_SPACE.StaticValue.PopulationGrowthRatePerMonth.Add(STATIC_SPACE.StaticValue.Population);
                STATIC_SPACE.StaticValue.NationalTreasury -= STATIC_SPACE.StaticValue.Population * CONSTATIC_SPACE.ConstaticValue.NationalCost;
            }
            else
            {
                STATIC_SPACE.StaticValue.Population += 1;
                STATIC_SPACE.StaticValue.PopulationGrowthRatePerMonth.Add(STATIC_SPACE.StaticValue.Population);
                STATIC_SPACE.StaticValue.NationalTreasury -= STATIC_SPACE.StaticValue.Population * CONSTATIC_SPACE.ConstaticValue.NationalCost;
            }
        }
	}
}
