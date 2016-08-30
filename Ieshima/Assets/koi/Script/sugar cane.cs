using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class sugarcane : FarmClass
{
    public GameObject BrawnSugarFactory;
    protected void GrawUp();
    protected int MonthChangeCheck;
    public GameObject BrawnSugarFactory; //隣接工場
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
            GrawUp();
        }    
            if (CheckHarvestDay()) {
               
            }
                if(){
                FactoryFlag  = false;
                     }
                else{
                Gain ( CONSTATIC_SPACE.ConstaticValue.Price_of_Sugarcane);
                Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_Sugarcane);
                }
            }
        }