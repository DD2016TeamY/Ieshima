using UnityEngine;
using System.Collections;

public class LinkSugarandBrawn : MonoBehaviour {
    public bool LinkFlag;

	// Use this for initialization
	void Start () {
        LinkFlag = false;
	}

    void OnTriggerStay(Collider factory)
    {
        if (LinkFlag == false && factory.gameObject.tag == "BrownSugarFactroy")
        { 
            LinkFlag = true;
            if (this.GetComponent<sugarcane>().BrawnSugarFactory != null && this.GetComponent<sugarcane>().BrawnSugarFactory.tag == "RumFactory") ;
            else
            {
                this.GetComponent<sugarcane>().BrawnSugarFactory = factory.gameObject;
                this.GetComponent<sugarcane>().FactoryFlag = true;
            }
        }
    }
}
