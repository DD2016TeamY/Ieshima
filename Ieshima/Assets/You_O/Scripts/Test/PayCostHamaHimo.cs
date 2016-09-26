using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class PayCostHamaHimo : BaseClass {	
	// Update is called once per frame
	void Update () {
	if(CheckChangeMonth() && STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            PayCost(CONSTATIC_SPACE.ConstaticValue.ContractFee_of_Hamahimo);
        }

	}
}
