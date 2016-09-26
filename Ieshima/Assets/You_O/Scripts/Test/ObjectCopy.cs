using UnityEngine;
using System.Collections;
using STATIC_SPACE;

public class ObjectCopy : MonoBehaviour
{
    GameObject NowCreate;
    public GameObject ToCreate;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && STATIC_SPACE.StaticValue.ConstructionFlag)
        {
            NowCreate = (GameObject)Instantiate(ToCreate, this.transform.position, this.transform.rotation);
            STATIC_SPACE.StaticValue.ConstructionFlag = false;
            Destroy(this.gameObject);
        }
    }
}