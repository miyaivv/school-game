using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public CharacterController controller;

    [SerializeField] private float movementSpeed;

    public float gravity = -9.81f;

    Vector3 velocity;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * movementSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}

//CODE FROM: https://www.youtube.com/watch?v=_QajrabyTJc&t=856s