using UnityEngine;
using System.Collections;

public class NewBehaviourScript : BaseClass{


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (CheckChangeMonth())
        {
            STATIC_SPACE.StaticValue.PopulationGrowthRatePerMonth.Add(STATIC_SPACE.StaticValue.Population);
        }
	}
}
