using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class ConstructButton : MonoBehaviour {

    public GameObject NameImage;
    public GameObject Facility;

    public void OnMouseDraw()
    {
        NameImage.SetActive(true);
    }

    public void OnMouseDontDraw()
    {
        NameImage.SetActive(false);
    }

    public void ClickOn()
    {
        STATIC_SPACE.StaticValue.ConstructionFlag = true;
        STATIC_SPACE.StaticValue.ConstructFacility = Facility;
    }
}
