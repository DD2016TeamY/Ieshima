using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;
public class Tobaccofield : FarmClass
{
    public GameObject TobaccoFactory;

	// Use this for initialization
	void Start () {
         HarvestDays = CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_LeafTobacco;
    
    }
	
	// Update is called once per frame
	void Update () {
        if(CheckChangeMonth()){
            GrowUp();
            }
            if(FactoryFlag){
                //TobaccoFactory.GetComponent<>;
                //TobaccoGrowh  =  ProbuceGrowth;
                } else{
                Gain(CONSTATIC_SPACE.ConstaticValue.Price_of_LeafTobacco);
                Reset(CONSTATIC_SPACE.ConstaticValue.HarvestDays_of_LeafTobacco);                
                }
            }
      }