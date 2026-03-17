using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 25f;
    [SerializeField] private float turnSpeed = 45f;

    private void Update()
    {
        float turnInput = Input.GetAxis("Horizontal");
        float moveInput = Input.GetAxis("Vertical");

        Move(moveInput);
        Turn(turnInput, moveInput);
    }

    private void Move(float moveInput)
    {
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveAmount);
    }

    private void Turn(float turnInput, float moveInput)
    {
        if (moveInput == 0f)
        {
            return;
        }

        float turnAmount = turnInput * turnSpeed * moveInput * Time.deltaTime;
        transform.Rotate(Vector3.up, turnAmount);
    }
}