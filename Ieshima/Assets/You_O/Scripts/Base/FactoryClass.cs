using UnityEngine;
using System.Collections;

public class FactoryClass : BaseClass {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    protected bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ

    //建設期間を減らす
    protected void DecreaseConstructionTime()
    {
        if(ConstructionTime > 0)
        {
            ConstructionTime--;
        }
<<<<<<< HEAD
    }

    //維持費を支払う
    protected void PayRunningCost(int runningcost)
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= runningcost;
    }

    //電力を受容する
=======
    }

    //電力を受容する
>>>>>>> 20cfa5d1209d2a9d1fb4756353bba08f84cb0fc1
    protected void SetPower()
    {
        if(STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.PowerGanaration_of_Hamahimo;
        }
        else if(Wind_PowerGeneratorFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
        }
        else
        {
            GetPower = 0;
        }
    }
}
