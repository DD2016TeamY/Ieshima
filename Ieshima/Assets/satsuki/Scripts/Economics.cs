﻿using UnityEngine;
using System.Collections;

public class Economics : BaseClass {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (CheckChangeMonth())
        {
            STATIC_SPACE.StaticValue.NationalTreasuryPerMonth.Add(STATIC_SPACE.StaticValue.NationalTreasury);
        }
	
	}
}
