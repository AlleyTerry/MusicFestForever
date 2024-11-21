using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Yarn;
using Yarn.Unity;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public DialogueRunner dialogueRunner;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            return;
        }
        
        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider)
        {
            return;
        }
        
        Debug.Log(rayHit.collider.gameObject.name);
        
        dialogueRunner.StartDialogue(rayHit.collider.gameObject.name);
        
    }
}
