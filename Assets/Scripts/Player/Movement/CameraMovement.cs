using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameManager gameManager;



    [SerializeField] private float mouseSensetivity;

    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    
    void Update()
    {
        if (gameManager.canMove == true)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);


            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }

        if (gameManager.canMove == false)
        {
            Cursor.lockState -= CursorLockMode.Locked;
        }

    }
}

//CODE FROM: https://www.youtube.com/watch?v=_QajrabyTJc&t=856s