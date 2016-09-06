using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class GotoPrev : FactoryClass{
    public GameObject PrevOage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   void GotoNextPage(){
    PrevOage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}