using UnityEngine;
using System.Collections;

public class Contorol : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rigi;
    float movePower = 0.2f;
    bool jumppingFlug = true;

    // Use this for initialization
    void Start()
    {
        rigi = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector4(
            Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal") * -1);
        transform.Translate(move * Time.deltaTime * speed);

        if (Input.GetKeyUp("space"))
        {
            jumppingFlug = false;
        }
        if (Input.GetKeyDown("space"))
        {
            jumppingFlug = true;
            if (jumppingFlug == true)
            {
                Jump();
            }
        }
    }
    void Jump()
    {
        jumppingFlug = false;
        rigi.AddForce(Vector3.up * 100);
    }
    //Vector3 move = new Vector4(
    //    Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal") * -1);
    //rigi.velocity = move * Time.deltaTime * speed;

}


