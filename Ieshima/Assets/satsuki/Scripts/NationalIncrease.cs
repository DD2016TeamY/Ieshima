using UnityEngine;
using System.Collections;

public class NewBehaviourScript : BaseClass {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (CheckChangeMonth())
        {
            STATIC_SPACE.StaticValue.Population += 10;
            if (STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 1] > 
                    STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 2])
            {
                   STATIC_SPACE.StaticValue.Population += ((STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 1] -
                       STATIC_SPACE.StaticValue.NationalTreasuryPerMonth[STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Count - 2]) * 
                            CONSTATIC_SPACE.ConstaticValue.)
            }
        }
	
	}
}
