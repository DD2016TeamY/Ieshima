using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;


public class Redpotatoes : FarmClass
{
    public GameObject PurupuruFactory;
     protected int RedPotatoGrowth;
    // Use this for initialization
    void Start()
    {
        HarvestDays = CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_RedPotato;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckChangeMonth())
        {
            GrowUp();

            if (CheckHarvestDay())
            {
                if (FactoryFlag == true)
                {
                   // RedPotatoGrowth = ProduceGrowth;
                }
                else
                {
                    
                    Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_RedPotato);
                    Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_RedPotato);
                }
            }
        }
    }
}
