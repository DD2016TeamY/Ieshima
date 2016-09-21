using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    private Vector3 MousePosition;
    private Vector3 BeforeMousePosition;
    private Vector3 MoveCameraPositionVertical;
    private Vector3 MoveCameraPositionHorizontal;
    private float cameradirectionX;
    private float cameradirectionZ;

    // Use this for initialization
    void Start()
    {
        MousePosition = Input.mousePosition;
        cameradirectionX = transform.forward.x * 3;
        cameradirectionZ = transform.forward.z * 3;
    }

    // Update is called once per frame
    void Update()
    {
        BeforeMousePosition = MousePosition;
        MousePosition = Input.mousePosition;

        if (Input.GetMouseButton(1))
        {
            if ((BeforeMousePosition.x - MousePosition.x) * (BeforeMousePosition.x - MousePosition.x) > (BeforeMousePosition.y - MousePosition.y) * (BeforeMousePosition.y - MousePosition.y))
            {
                if (BeforeMousePosition.x < MousePosition.x)
                {
                    Vector3 MoveDistance = new Vector3(-cameradirectionZ, 0, cameradirectionX);
                    MoveCameraPositionHorizontal = MoveDistance;
                }
                else if (BeforeMousePosition.x > MousePosition.x)
                {
                    Vector3 MoveDistance = new Vector3(cameradirectionZ, 0, -cameradirectionX);
                    MoveCameraPositionHorizontal = MoveDistance;
                }
                else
                {
                    Vector3 MoveDistance = new Vector3(0, 0, 0);
                    MoveCameraPositionHorizontal = MoveDistance;
                }

                MoveCameraPositionVertical = new Vector3(0, 0, 0);
            }
            else
            {
                if (BeforeMousePosition.y < MousePosition.y)
                {
                    Vector3 MoveDistance = new Vector3(-cameradirectionX, 0, -cameradirectionZ);
                    MoveCameraPositionVertical = MoveDistance;
                }
                else if (BeforeMousePosition.y > MousePosition.y)
                {
                    Vector3 MoveDistance = new Vector3(cameradirectionX, 0, cameradirectionZ);
                    MoveCameraPositionVertical = MoveDistance;
                }
                else
                {
                    Vector3 MoveDistance = new Vector3(0, 0, 0);
                    MoveCameraPositionVertical = MoveDistance;
                }

                MoveCameraPositionHorizontal = new Vector3(0, 0, 0);
            }

            transform.position += MoveCameraPositionVertical;
            transform.position += MoveCameraPositionHorizontal;

            if (transform.position.x < 75)
            {
                transform.position = new Vector3(75, transform.position.y, transform.position.z);
            }
            if(transform.position.x > 150)
            {
                transform.position = new Vector3(150, transform.position.y, transform.position.z);
            }
            if(transform.position.z < -175)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y , -175);
            }
            if(transform.position.z > 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            }
        }
    }
}
