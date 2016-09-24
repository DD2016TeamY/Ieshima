using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
using System.Collections.Generic;

public class Windfarm : FactoryClass
{
    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.Wind_PowerGeneratorCost);

        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.ConstructionTime_of_Wind_PowerGenerator;
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {
            if (CheckChangeMonth())
            {
                PayCost(CONSTATIC_SPACE.ConstaticValue.Wind_PowerGeneratorRunningCost);
            }
        }
        else
        {
            if (CheckChangeMonth())
            { 
                DecreaseConstructionTime();

                if (ConstructionTime <= 0)
                {
                    ConstructedFlag = true;
                }
            }
        }
    }

    //void OnTriggerStay(Collider factory)
    //{
    //    if (CheckChangeMonth())
    //    {
    //        if (factory.gameObject.tag == "RumFactory")
    //        {
    //            Debug.Log(2);
    //            factory.gameObject.GetComponent<RumFactory>().GetPower += CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
    //        }
    //        else if (factory.gameObject.tag == "TobaccoFactory")
    //        {
    //            Debug.Log(3);
    //            factory.gameObject.GetComponent<TobaccoFactory>().GetPower += CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
    //        }
    //        else if (factory.gameObject.tag == "Hotel")
    //        {
    //            Debug.Log(4);
    //            factory.gameObject.GetComponent<Hotel>().GetPower += CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;
    //        }
    //    }
    //}
}