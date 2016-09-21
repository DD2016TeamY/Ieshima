using UnityEngine;
using System.Collections;

public class LinkSugarandBrawn : MonoBehaviour {
    public bool LinkFlag;

	// Use this for initialization
	void Start () {
        LinkFlag = false;
	}

    void Update()
    {
    }

    void OnTriggerStay(Collider factory)
    {
        Debug.Log(factory.gameObject.tag);
        Debug.Log(LinkFlag);

        if (LinkFlag == false && factory.gameObject.tag == "BrawnSugarFactroy")
        {
            Debug.Log("Hello, world!");

            LinkFlag = true;

            this.transform.parent.GetComponent<sugarcane>().BrawnSugarFactory = factory.transform.parent.gameObject;

            this.transform.parent.GetComponent<sugarcane>().FactoryFlag = true;
        }
    }
}
