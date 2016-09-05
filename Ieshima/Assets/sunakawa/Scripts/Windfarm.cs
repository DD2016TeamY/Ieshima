using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
using System.Collections.Generic;

public class Windfarm : FactoryClass
{
    public List<GameObject> FactorysList;

    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.Wind_PowerGeneratorCost);

        ConstructionTime = CONSTATIC_SPACE.ConstaticValue.WindPowerGenerate;

        FactorysList = new List<GameObject>();
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
                if(other.gameObject.GetComponent<RumFactory>().Wind_PowerGeneratorFlag == false)
                {
                    gameObject.GetComponent<RumFactory>().Wind_PowerGeneratorFlag = true;

                    FactorysList.Add(other.gameObject);
                }
                else if (other.gameObject.tag == "TobaccoFactory")
                {
                    if (gameObject.GetComponent<TobaccoFactory>().Wind_PowerGeneratorFlag == false)
                    {
                        gameObject.GetComponent<TobaccoFactory>().Wind_PowerGeneratorFlag = true;

                        FactorysList.Add(other.gameObject);
                    }
                }
                else if (other.gameObject.tag == "Hotel")
                {
                    if (other.gameObject.GetComponent<Hotel>().Wind_PowerGeneratorFlag == false)
                    {
                        gameObject.GetComponent<Hotel>().Wind_PowerGeneratorFlag = true;

                        FactorysList.Add(other.gameObject);
                    }

                }
            }
        }

     
    }

    /*void DestroyThisGenerator()
    {
        for (int i = 0; i < FactorysList.Count; i++)
        {
            if (other.gameObject.tag == "RumFactory")
            { 
                
            }
        }
    }*/
}