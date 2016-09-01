using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Hotel : FactoryClass
{

    // Use this for initialization
    void Start()
    {
        PayCost(CONSTATIC_SPACE.ConstaticValue.HotelCost);
    }

    // Update is called once per frame
    void Update()
    {

    }
}