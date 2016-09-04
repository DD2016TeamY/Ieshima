using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
public class sugarcane : FarmClass
{
    public GameObject BrawnSugarFactory;
    protected int MonthChangeCheck;
    // Use this for initialization
    void Start()
    {

        HarvestDays = CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane;
        MonthChangeCheck = STATIC_SPACE.StaticValue.Month;
    }

    // Update is called once per frame
    void Update() {
        if (STATIC_SPACE.StaticValue.Month == MonthChangeCheck)
        {
            GrowUp();
        }    
            if (CheckHarvestDay()) {
               
            }
               if(FactoryFlag == true){
                   
                }
                else{
<<<<<<< HEAD
                GainBrand ( CONSTATIC_SPACE.ConstaticValue.Price_of_Sugarcane);
=======
                Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_Sugarcane);
>>>>>>> 917114ad9ec6dde39c4c62f158de6e17a7b06339
                Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
                }
        }
}