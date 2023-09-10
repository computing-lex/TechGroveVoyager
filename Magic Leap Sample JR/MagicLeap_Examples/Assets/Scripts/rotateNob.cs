using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.MagicLeap;
using static MagicLeapInputs;

public class rotateNob : MonoBehaviour
{
    MagicLeapInputs mlInputs;
    MagicLeapInputs.ControllerActions controllerActions;
    Vector2 triggerValue;
    Animator nob = null;

    bool turnTheNob;

    private void Start()
    {
        mlInputs = new MagicLeapInputs();
        mlInputs.Enable();
        controllerActions = new MagicLeapInputs.ControllerActions(mlInputs);
        controllerActions.TouchpadPosition.performed += HandleOnTouchpad;
        nob = GetComponent<Animator>();
    }

    private void HandleOnTouchpad(InputAction.CallbackContext obj)
    {
        triggerValue = obj.ReadValue<Vector2>();
    }

    private void Update()
    {
        //nob.SetFloat("Horizontal", triggerValue.x);
        //nob.SetFloat("Vertical", triggerValue.y);
       
        if (turnTheNob)
        {
            nob.SetFloat("Horizontal", triggerValue.x);
            nob.SetFloat("Vertical", triggerValue.y);
        }
    }

    public void allowToTurn()
    {
        turnTheNob = true;

    }

    public void stopTurning()
    {
        turnTheNob = false;
    }
}
