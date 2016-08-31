using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FactoryClass : BaseClass {
    protected int ConstructionTime = -1; //建設期間
    protected int GetPower = 0; //取得電力
    public bool Wind_PowerGeneratorFlag = false; //風力発電機フラグ
    protected bool ConstructedFlag = false; //建設済みフラグ
    public List<GameObject> Wind_PowerGenerators = new List<GameObject>();

    protected void DecreaseConstructionTime()
    {
        if(ConstructionTime > 0)
        {
            ConstructionTime--;
        }
    }
  
    //電力を受容する
    protected void SetPower()
    {
        if (STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.PowerGanaration_of_Hamahimo;
        }
        else if (Wind_PowerGeneratorFlag)
        {
            GetPower = CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate * Wind_PowerGenerators.Count;
        }
        else
        {
            GetPower = 0;
        }
    }
}
