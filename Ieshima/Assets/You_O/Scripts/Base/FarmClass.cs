using UnityEngine;
using System.Collections;

public class FarmClass : BaseClass {

    protected int ProduceGrowth = 0;
    protected int HarvestDays;
    protected bool FactoryFlag = false;

    protected void GrowUp()
    {
        ProduceGrowth += UnityEngine.Random.Range(1, CONSTATIC_SPACE.ConstaticValue.MaximumGrowth);
    }

    protected bool CheckHarvestDay()
    {
        if(--HarvestDays <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected void Reset(int harvestdays)
    {
        HarvestDays = harvestdays;
        ProduceGrowth = 0;
    }
}