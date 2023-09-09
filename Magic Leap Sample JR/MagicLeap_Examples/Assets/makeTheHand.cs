using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class makeTheHand : MonoBehaviour
{

    MagicLeapInputs mlInputs;
    MagicLeapInputs.ControllerActions controllerActions;
    float triggerButtonValue;

    public MeshRenderer hand;

    bool handTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        mlInputs = new MagicLeapInputs();
        mlInputs.Enable();
        controllerActions = new MagicLeapInputs.ControllerActions(mlInputs);
        controllerActions.TriggerButton.performed += HandleOnTrigger;
    }

    private void HandleOnTrigger(InputAction.CallbackContext obj)
    {
        triggerButtonValue = obj.ReadValue<float>();
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerButtonValue > 0 && !handTriggered)
        {
            hand.enabled = true;
            handTriggered = true;
        }
    }
}
