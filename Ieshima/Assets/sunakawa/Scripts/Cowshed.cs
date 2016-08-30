using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Cowshed : FarmClass
{
    
    // Use this for initialization
    void Start()
    {
        STATIC_SPACE.StaticValue.NationalTreasury -= CONSTATIC_SPACE.ConstaticValue.RearingCowCost;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
