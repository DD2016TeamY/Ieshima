using UnityEngine;
using System.Collections;
using STATIC_SPACE;

public class Desroyfacility : MonoBehaviour {
    public void ClickOn()
    {
        if(!STATIC_SPACE.StaticValue.DestroyFlag)
        {
            STATIC_SPACE.StaticValue.DestroyFlag = true;
        }
    }
}
