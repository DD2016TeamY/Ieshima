//<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class FactoryClass : MonoBehaviour {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    protected bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ

    //建設期間を減らす=======
﻿using UnityEngine;
using System.Collections;

public class FactoryClass : BaseClass {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    protected bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ

    //建設期間を減らす>>>>>>> acfad6d467506e3b12782f0698a45f68f422b320
    protected void DecreaseConstructionTime()
    {
        if(ConstructionTime > 0)
        {
            ConstructionTime--;
        }
    }

    //維持費を支払う
    protected void PayRunningCost(int runningcost)
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= runningcost;
    }

    //電力を受容する
    protected void SetPower()
    {
        if(STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.PowerGanaration_of_Hamahimo;
        }
        else
        {
            GetPower = 0;
        }
    }
}
}