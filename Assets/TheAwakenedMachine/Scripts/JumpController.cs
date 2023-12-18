//this script allows you to jump in New Input System

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class JumpController : MonoBehaviour
{
    private XRIDefaultInputActions inputAction;
    [SerializeField] private InputActionReference jumpButton;
    public float jumpHeight = 2.5f; //how high you can jump
    public float gravityValue = -9.81f; //free fall acceleration

    private CharacterController characterController;
    private Vector3 playerVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        Debug.Log("JumpController.cs: CharacterController is Awake and ready to jump");

        inputAction = new XRIDefaultInputActions();
        inputAction.Enable();
    }

    private void OnEnable() {
        Debug.Log("JumpController.cs: Character controller is jumping. OnEnable");
        inputAction.Enable();
        inputAction.XRILeftHandLocomotion.Jump.started += Jump; //New Input System on left controller
    }

    private void OnDisable() {
        inputAction.XRILeftHandLocomotion.Jump.started -= Jump;
        inputAction.Disable();
    }

    private void Jump(InputAction.CallbackContext args) 
    {
        if (!characterController.isGrounded) return; //checking whether the Player is not standing on feet
        playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravityValue); //sets the vertical movement during the Jump
        Debug.Log("JumpController.cs: Jumping!");
    }

    private void Update()
    {
        if (characterController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }

}
