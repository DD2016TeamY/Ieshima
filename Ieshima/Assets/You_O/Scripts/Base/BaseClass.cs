using UnityEngine;
using System.Collections;

public class BaseClass : MonoBehaviour
{

    protected int CheckNowMonth = 0;  //月チェック用変数

    //月が替わったか調べる
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

    //コストを支払う
    protected void PayCost(int cost)
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= cost;
    }

}
