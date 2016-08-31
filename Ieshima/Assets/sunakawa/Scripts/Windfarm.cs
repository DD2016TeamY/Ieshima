using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
using System.Collections.Generic;

public class Windfarm : FactoryClass
{
    public GameObject FactorysList;

    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.Wind_PowerGeneratorCost);

        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;

        FactorysList = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (ConstructedFlag)
        {

        }
        else if (CheckChangeMonth())
        {
            DecreaseConstructionTime();

            if (ConstructionTime <= 0)
            {
                ConstructedFlag = true;

            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (CheckChangeMonth() && ConstructedFlag)
        {
            if (other.gameObject.tag == "RumFactory")
            {
                if(other.gameObject.GetComponent<Windfarm>().Wind_PowerGeneratorFlag == false)//危うい
                {
                    other.gameObject.GetComponent<Windfarm>().Wind_PowerGeneratorFlag = true;

                }
            }
        }
    }
}