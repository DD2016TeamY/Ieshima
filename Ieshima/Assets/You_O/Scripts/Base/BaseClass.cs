using UnityEngine;
using System.Collections;

public class BaseClass
{

    protected int CheckNowMonth = 0;  //月チェック用変数

    protected bool CheckChangeMonth()
    {
        if (CheckNowMonth == STATIC_SPACE.StaticValue.Month)
        {
            CheckNowMonth = STATIC_SPACE.StaticValue.Month;
            return false;
        }
        else
        {
            CheckNowMonth = STATIC_SPACE.StaticValue.Month;
            return true;
        }
    }

    protected void PayCost(int cost)
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= cost;
    }

    protected void Gain(int profit)
    {
        STATIC_SPACE.StaticValue.NationalTreasury = profit;
    }
}
