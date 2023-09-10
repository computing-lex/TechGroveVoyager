using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class initalizeScene : MonoBehaviour
{

    MagicLeapInputs mlInputs;
    MagicLeapInputs.ControllerActions controllerActions;
    float triggerButtonValue;

    public GameObject reference;
    public GameObject origin;
    public bool initalized = false;

    [SerializeField] private Vector3[] calibration = new Vector3[2];
    private int calibrationCount = 0;
    private GameObject[] referencePoints = new GameObject[2];
    private bool handTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        mlInputs = new MagicLeapInputs();
        mlInputs.Enable();
        controllerActions = new MagicLeapInputs.ControllerActions(mlInputs);
        controllerActions.TriggerButton.performed += HandleOnTrigger;
        controllerActions.TriggerButton.canceled += HandleOnTrigger;
    }

    private void HandleOnTrigger(InputAction.CallbackContext obj)
    {
        triggerButtonValue = obj.ReadValue<float>();
    }

    // Update is called once per frame
    void Update()
    {
        if (calibrationCount >= calibration.Length)
        {
            origin.transform.position = calibration[0];
            origin.transform.LookAt(new Vector3(calibration[1].x, origin.transform.position.y, calibration[1].z));
            
            foreach (GameObject point in referencePoints)
            {
                Destroy(point);
            }

            calibrationCount = 0;
            initalized = true;
        }

        if (triggerButtonValue != 0 && !handTriggered && !initalized)
        {
            setCalibrationPoint(transform.position, calibrationCount);
            referencePoints[calibrationCount] = Instantiate(reference, calibration[calibrationCount], Quaternion.identity);
            calibrationCount++;
            handTriggered = true;
        }
        if (triggerButtonValue == 0 && handTriggered)
        {
            handTriggered = false;
        }
    }

    void setCalibrationPoint(Vector3 point, int index)
    {
        calibration[index] = point;
    }
}