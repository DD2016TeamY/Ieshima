using UnityEngine;
using System.Collections;
using STATIC_SPACE;

public class HamaHimo : MonoBehaviour {
    public void ClickOn()
    {
        STATIC_SPACE.StaticValue.ContractHamahimoDenryokuFlag = true;
    }
}
