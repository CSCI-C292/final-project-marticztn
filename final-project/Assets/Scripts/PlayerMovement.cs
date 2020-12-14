using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 10f;
    [SerializeField] float _moveSpeed = 3f;
    [SerializeField] Camera _cam;
    [SerializeField] GameObject ItemName;
    float _currentTilt = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        ItemName.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        Movement();

        if(Input.GetMouseButtonDown(0))
        {

        }
    }

    void Aim()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Pan around the object - Vector3.up means to rotate around the Y axis (up)
        transform.Rotate(Vector3.up, mouseX * _mouseSensitivity);

        // Tilt the object up and down
        _currentTilt -= mouseY * _mouseSensitivity;                         // Tilting
        _currentTilt = Mathf.Clamp(_currentTilt, -90, 90);                  // Limiting the euler angle with 90 degrees
        _cam.transform.localEulerAngles = new Vector3(_currentTilt, 0, 0);  // Apply the euler angle transformation
    }

    void Movement()
    {
        Vector3 sidewaysMovementVector = transform.right * Input.GetAxis("Horizontal");
        Vector3 forwardBackwardMovementVector = transform.forward * Input.GetAxis("Vertical");
        Vector3 movementVector = sidewaysMovementVector + forwardBackwardMovementVector;

        GetComponent<CharacterController>().Move(movementVector * _moveSpeed * Time.deltaTime);
    }
}
