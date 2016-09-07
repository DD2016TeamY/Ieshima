using UnityEngine;
using System.Collections;
using STATIC_SPACE;
public class Typhoon : BaseClass
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
	}

   void WaitForFixedUpdate(){
       if (CheckChangeMonth())
       {
           STATIC_SPACE.StaticValue.TyphoonFlag = false;
       }
       if (STATIC_SPACE.StaticValue.Month / 7 == 0 || STATIC_SPACE.StaticValue.Month / 8 == 0 ||
          STATIC_SPACE.StaticValue.Month / 9 == 0) 
       {
           if (Random.Range(0, 100) < 41)
           {
               STATIC_SPACE.StaticValue.TyphoonFlag = true;
           }
       }

    }
}
