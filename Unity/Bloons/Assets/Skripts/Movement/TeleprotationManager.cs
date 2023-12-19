using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleprotationManager : MonoBehaviour
{
    /*[SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private XRRayInteractor rayInteractor;
    [SerializeField] private TeleportationProvider provider;
   
    private InputAction thumbstick;
    [SerializeField] private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test");
        rayInteractor.enabled = false;

        var activate = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Activate");
        activate.Enable();
        activate.performed += OnTeleportActivate;

        var cancel = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Teleport Mode Cancel");
        cancel.Enable();
        cancel.performed += OnTeleportCancel;

        thumbstick = actionAsset.FindActionMap("XRI LeftHand Locomotion").FindAction("Move");
        thumbstick.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isActive)
        {
            return;
        }

        if(thumbstick.triggered)
        {
            Debug.Log("thumbstick Triggert");
            return;
        }

        if (!rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit)){
            rayInteractor.enabled = false;
            isActive = false;
            return;
        }

        TeleportRequest request = new TeleportRequest()
        {
            destinationPosition = hit.point,
            //destinationRotation = hit.transform.rotation,
            //matchOrientation = ,
            //requestTime = ,
        };

        provider.QueueTeleportRequest(request);
        rayInteractor.enabled = false;
        isActive = false;
 
    }

    private void OnTeleportActivate(InputAction.CallbackContext context)
    {
        rayInteractor.enabled = true;
        isActive = true;
        Debug.Log("Activate");
    }

    private void OnTeleportCancel(InputAction.CallbackContext context)
    {
        rayInteractor.enabled = false;
        isActive = false;
        Debug.Log("deactivate");
    }
    */
}
