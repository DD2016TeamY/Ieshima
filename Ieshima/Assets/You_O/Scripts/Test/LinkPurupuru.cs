using UnityEngine;
using System.Collections;

public class LinkPurupuru : MonoBehaviour {
    public bool LinkFlag;

    // Use this for initialization
    void Start()
    {
        LinkFlag = false;
    }

    void OnTriggerStay(Collider factory)
    {
        if (LinkFlag == false && factory.gameObject.tag == "PurupuruFactory")
        {
            LinkFlag = true;
            this.GetComponent<Redpotatoes>().PurupuruFactory = factory.gameObject;
            this.GetComponent<Redpotatoes>().FactoryFlag = true;
        }
    }
}
