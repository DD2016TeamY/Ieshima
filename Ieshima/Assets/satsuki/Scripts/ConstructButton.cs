using UnityEngine;
using System.Collections;
using STATIC_SPACE;
using CONSTATIC_SPACE;

public class ConstructButton : MonoBehaviour {

    public GameObject NameImage;
    public GameObject Facility;
    private GameObject NowCreate;

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
        NowCreate = Instantiate(Facility);
        STATIC_SPACE.StaticValue.ConstructFacility = NowCreate;
    }
}
