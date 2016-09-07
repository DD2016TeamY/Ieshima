using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class GotoNextPage : FactoryClass {
    public GameObject NextPage;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     GotoNextPage(){
        NextPage.SetActive(true);
        this.gameObject.SetActive(false);
    } 
 }
