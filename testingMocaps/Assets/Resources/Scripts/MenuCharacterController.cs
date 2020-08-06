using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCharacterController : MonoBehaviour
{
    [Header("INSERT MAIN CAMERA CONTROLLER SO :")]
    public MainCameraController_SO MainCameraControllerVariables;

    public Vector3 rotateStartPosition = new Vector3();
    public Vector3 rotateCurrentPosition = new Vector3();
    public Quaternion newRotation = new Quaternion();
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        newRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * speed);
    }

    public void MouseInput()
    {
        if (Input.GetMouseButtonDown(2))
        {
            //if (EventSystem.current.IsPointerOverGameObject())
            //{
            //    return;
            //}
            //MainCameraControllerVariables.rotateStartPosition = Input.mousePosition;
            rotateStartPosition = Input.mousePosition;

        }

        if (Input.GetMouseButton(2))
        {
            //MainCameraControllerVariables.rotateCurrentPosition = Input.mousePosition;
            rotateCurrentPosition = Input.mousePosition;

            //Vector3 difference = MainCameraControllerVariables.rotateStartPosition - MainCameraControllerVariables.rotateCurrentPosition;
            Vector3 difference = rotateStartPosition - rotateCurrentPosition;

            //MainCameraControllerVariables.rotateStartPosition = MainCameraControllerVariables.rotateCurrentPosition;
            rotateStartPosition = rotateCurrentPosition;

            //MainCameraControllerVariables.newRotation *= Quaternion.Euler(Vector3.up * (-difference.x / 5f));
            newRotation *= Quaternion.Euler(Vector3.up * (-difference.x / 5f));
            Debug.Log("cu");
            //transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * speed);
        }
    }
}
