using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class Festival : BaseClass {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate(){
        if (CheckChangeMonth()) {
            STATIC_SPACE.StaticValue.EventsScale = 1;
            if (STATIC_SPACE.StaticValue.Month == 4) {
                STATIC_SPACE.StaticValue.EventsScale = CONSTATIC_SPACE.ConstaticValue.Scale_of_MarathonTournament;
            }else if ( STATIC_SPACE.StaticValue.Month == 5){
            STATIC_SPACE.StaticValue.EventsScale  =   CONSTATIC_SPACE.ConstaticValue.Scale_of_LilyFestival;
            }
            else if(STATIC_SPACE.StaticValue.Month == 6){
                STATIC_SPACE.StaticValue.EventsScale =  CONSTATIC_SPACE.ConstaticValue.Scale_of_SeaGodFestival;
            }
        }       
     }
   }
