using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class BrownSugarFactory : FactoryClass {

    private int SugarcaneGrowth; //工場に入ってくるサトウキビ 

	// Use this for initialization
	void Start () {
        SugarcaneGrowth = 0;
        PayCost(CONSTATIC_SPACE.ConstaticValue.BrownSugarFactoryCost);

	}
	
	// Update is called once per frame
	void Update () {


	}



}
