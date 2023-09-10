using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class initalizeScene : MonoBehaviour
{

    MagicLeapInputs mlInputs;
    MagicLeapInputs.ControllerActions controllerActions;
    float triggerButtonValue;

    public GameObject hand;
    public GameObject origin;

    bool handTriggered = false;
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
        if (triggerButtonValue != 0 && !handTriggered)
        {
            origin.transform.position = transform.position;
            origin.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            handTriggered = true;
        }
        if (triggerButtonValue == 0 && handTriggered)
        {
            handTriggered = false;
        }
    }
}