﻿using UnityEngine;
using System.Collections;

public class Scenetitle : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.Mouse0)))
        {
            Application.LoadLevel("mainscene");
        }
	}
}
