using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using Valve.VR;

public class KeyListener : MonoBehaviour
{
    public InputAction TeleportActive;
    public InputAction TeleportSelect;
    public InputAction TeleportCancel;
    // Start is called before the first frame update
    void Start()
    {
        //InputActionAsset defaultInputActionAsset = gameObject.GetComponent<InputActionManager>().actionAssets[0];
        //TeleportActive = defaultInputActionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Activate");
        //TeleportActive.performed += ActivateBehavior;
        //TeleportActive.canceled -= ActivateBehavior;
        SteamVR_Actions.default_Teleport.onStateDown += OnStateDown;
        SteamVR_Actions.default_Squeeze.onChange += usingSqueeze;
    }

    private void usingSqueeze(SteamVR_Action_Single fromAction, SteamVR_Input_Sources fromSource, float newAxis, float newDelta)
    {
        Debug.Log(newAxis.ToString());
    }

    private void OnDestroy()
    {
        SteamVR_Actions.default_Teleport.onStateDown -= OnStateDown;
    }
    void Update()
    {

    }

    private void OnStateDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        
        Debug.Log("1");
        print($"{fromAction.activeDevice},{fromSource}");
    }
    //private void ActivateBehavior(InputAction.CallbackContext context)
    //{
    //    print("1");
    //}
    //private void QuitBehavior(InputAction.CallbackContext context)
    //{
    //    print("2");
    //}
}
