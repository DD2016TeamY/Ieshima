using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class FactoryClass : BaseClass {
    protected int ConstructionTime = -1; //建設期間
    public int GetPower = 0; //取得電力
    protected bool ConstructedFlag = false; //建設済みフラグ

    protected void DecreaseConstructionTime()
    {
        if(ConstructionTime > 0)
        {
            ConstructionTime--;
        }
    }

    protected void SetPower()
    {
        if(STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.PowerGanaration_of_Hamahimo;
        }
    }
}
