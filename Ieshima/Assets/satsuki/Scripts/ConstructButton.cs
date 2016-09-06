using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class ConstructBumttom : MonoBehaviour {

    public GameObject NameImage;
    public GameObject Facility;

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
        STATIC_SPACE.StaticValue.ConstructionFlag = true;
        STATIC_SPACE.StaticValue.ConstructFacility = Facility;
    }
}
