using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class GetButtonPress : MonoBehaviour
{
    public bool canvasOn;
    public Canvas can;
    public InputActionReference toggleReference = null;

    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        //bool isActive = !gameObject.activeSelf;
        //gameObject.SetActive(isActive);
        //Debug.Log("This is the part where the gui fades in");
        if (canvasOn == true)
        {
            Debug.Log("Button Pressed");
            canvasOn = false;
            can.enabled = false;
        }
        else
        {
            canvasOn = true;
            can.enabled = true;
        }
    }
    
    void Start()
    {
        can.enabled = true;
        canvasOn = true;
        
    }

    void Update()
    {

    }
}

