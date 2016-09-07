using UnityEngine;
using System.Collections;

public class mousedeidousaseru : MonoBehaviour {
    public Camera MainCamera;
    public Transform target;
    public Transform center;
    bool flag;

	// Use this for initialization
	void Start () {
        flag = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null) return;

        Vector3 Pos = Vector3.forward * Vector3.Distance(transform.position, center.position);
        target.position = MainCamera.ScreenToWorldPoint(Input.mousePosition + Pos);
	}

}
