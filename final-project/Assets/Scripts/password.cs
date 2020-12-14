using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class password : MonoBehaviour
{
    [SerializeField] Camera _objectCameraView;
    [SerializeField] Camera _playerCameraView;

    [SerializeField] Canvas _canvas;

    bool flag = true;

    private void Start()
    {
        _playerCameraView.gameObject.SetActive(true);
        _objectCameraView.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!flag)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                _objectCameraView.gameObject.SetActive(false);
                _playerCameraView.gameObject.SetActive(true);
                _canvas.gameObject.SetActive(false);
                flag = true;
            }
        }
    }

    private void OnMouseDown()
    {
        if (flag)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

            _objectCameraView.gameObject.SetActive(true);
            _playerCameraView.gameObject.SetActive(false);
            _canvas.gameObject.SetActive(true);
            flag = false;
        }
    }
}
