using UnityEngine;
using System.Collections;

public class FarmClass : BaseClass {

    protected int ProduceGrowth = 0;    //作物の成長度
    protected int HarvestDays;  //収穫期間
    protected bool FactoryFlag = false; //隣接工場の存在フラグ

    //作物の成長
    protected void GrowUp()
    {
        ProduceGrowth += UnityEngine.Random.Range(1, CONSTATIC_SPACE.ConstaticValue.MaximumGrowth);
    }

    //利益の収集
    protected void Gain(int profit)
    {
        STATIC_SPACE.StaticValue.NationalTreasury += ProduceGrowth * profit;
    }

    protected void GainBrand(int profit , int brand_power = 1)
    {
        STATIC_SPACE.StaticValue.NationalTreasury += ProduceGrowth * profit * brand_power;
    }

    //収穫できるかどうか調べる
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

    //収穫期間をリセットする
    protected void Reset(int harvestdays)
    {
        HarvestDays = harvestdays;
        ProduceGrowth = 0;
    }

    //作物の成長度を取得する
    public int  GetGrowth()
    {
        return ProduceGrowth;
    }
}