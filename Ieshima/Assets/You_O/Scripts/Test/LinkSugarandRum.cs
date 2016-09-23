﻿using UnityEngine;
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
        if (LinkFlag == false && factory.gameObject.tag == "RumFactory")
        {
            LinkFlag = true;
            this.GetComponent<sugarcane>().BrawnSugarFactory = factory.gameObject;
            this.GetComponent<sugarcane>().FactoryFlag = true;
        }
    }
}
