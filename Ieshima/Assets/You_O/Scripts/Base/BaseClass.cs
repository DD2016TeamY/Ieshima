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
<<<<<<< HEAD
    }

    //建設費を支払う
=======
    }

    //コストを支払う
>>>>>>> 22a789ee534c675f93e5a370a2661e3c1b224ec0
    protected void PayCost(int cost)
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= cost;
    }

}
