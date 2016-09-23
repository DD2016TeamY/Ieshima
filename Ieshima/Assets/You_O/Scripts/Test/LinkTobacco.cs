using UnityEngine;
using System.Collections;

public class LinkTobacco : MonoBehaviour {
    public bool LinkFlag;

    // Use this for initialization
    void Start()
    {
        LinkFlag = false;
    }

    void OnTriggerStay(Collider factory)
    {
        if (LinkFlag == false && factory.gameObject.tag == "TobaccoFactory")
        {
            LinkFlag = true;
            this.GetComponent<Tobaccofield>().TobaccoFactory = factory.gameObject;
            this.GetComponent<Tobaccofield>().FactoryFlag = true;
        }
    }
}
