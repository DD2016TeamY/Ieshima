using UnityEngine;
using System.Collections;

public class LinkSugarandRum : MonoBehaviour {
    public bool LinkFlag;

    // Use this for initialization
    void Start()
    {
        LinkFlag = false;
    }

    void OnTriggerStay(Collider factory)
    {
        Debug.Log(1);
        if (LinkFlag == false && factory.gameObject.tag == "RumFactory")
        {
            Debug.Log(2);
            LinkFlag = true;
            this.GetComponent<sugarcane>().BrawnSugarFactory = factory.gameObject;
            this.GetComponent<sugarcane>().FactoryFlag = true;
        }
    }
}
