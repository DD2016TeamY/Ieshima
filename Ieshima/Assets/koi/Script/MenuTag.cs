using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;


public class MenuTag : FactoryClass{
    public GameObject Parents;
    public GameObject Child;
    public GameObject MemoryNowTag;
    public GameObject NowTag;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void ChangeTag() {

        Parents.GetComponent < MemoryNowTag.NowTag.SetActive(false) >

        Child.SetActive(true);
    
        Parents.GetComponent<MemoryNowTag.NowTag>() = Child;
    }
}