using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    // A lot of code was referenced from https://docs.unity3d.com/6000.6/Documentation/ScriptReference/CharacterController.Move.html
    Vector2 moveInput;

    float moveSpeed = 5f;
    float jumpHeight = 2.5f;
    float gravity = -9.81f;

    CharacterController controller;
    Vector3 playerVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        controller.Move(move * moveSpeed * Time.deltaTime);

        playerVelocity.y += gravity * Time.deltaTime;

        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (controller.isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    public void ResetVelocity()
    {
        playerVelocity = Vector3.zero;
    }
}
