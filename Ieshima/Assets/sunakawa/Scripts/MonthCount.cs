using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
public class MonthCount : MonoBehaviour
{

    int TimeCounter;
    bool flag;

    // Use this for initialization
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {

        TimeCounter = (int)Time.time;

        if (TimeCounter % 2 == 0)
        {
            if (flag)
            {
                flag = false;
                ++STATIC_SPACE.StaticValue.Month;
            }
        }
        else if (!flag)
        {
            flag = true;
        }
    }
}