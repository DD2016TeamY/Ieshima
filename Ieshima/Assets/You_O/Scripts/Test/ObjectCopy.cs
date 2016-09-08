using UnityEngine;
using System.Collections;
using STATIC_SPACE;

public class ObjectCopy : MonoBehaviour
{
    GameObject NowCreate;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && STATIC_SPACE.StaticValue.ConstructionFlag)
        {
            NowCreate = (GameObject)Instantiate(this.gameObject, this.transform.position, this.transform.rotation);
            NowCreate.GetComponent<ObjectCopy>().enabled = false;
            STATIC_SPACE.StaticValue.ConstructionFlag = false;
            gameObject.SetActive(false);
        }
    }
}