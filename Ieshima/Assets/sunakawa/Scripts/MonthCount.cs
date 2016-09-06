using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
public class MonthCount : MonoBehaviour {

    int TimeCounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        TimeCounter = (int)Time.time;

        if (TimeCounter == 60)
        {
            ++STATIC_SPACE.StaticValue.Month;
        }
	
	}
}
