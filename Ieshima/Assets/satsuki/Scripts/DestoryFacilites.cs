using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class DestroyFacilites : MonoBehaviour {

    public GameObject NameImage;

    void OnMouseEnter()
    {
        NameImage.SetActive(true);
    }

    void OnMouseExit()
    {
        NameImage.SetActive(false);
    }

    void OnMouseDown()
    {
        STATIC_SPACE.StaticValue.DestroyFlag = true;
    }

}
