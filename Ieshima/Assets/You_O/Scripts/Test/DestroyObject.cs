using UnityEngine;
using System.Collections;
using STATIC_SPACE;

public class DestroyObject : MonoBehaviour {

	void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0) && STATIC_SPACE.StaticValue.DestroyFlag)
        {
            STATIC_SPACE.StaticValue.DestroyFlag = false;
            Destroy(this.gameObject);
        }
    }
}
