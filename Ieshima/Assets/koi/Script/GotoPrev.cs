using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class GotoPrev : FactoryClass{
    public GameObject PrevPage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void GoToPrevPage(){
    PrevPage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}