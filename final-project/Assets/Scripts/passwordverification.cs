using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passwordverification : MonoBehaviour
{
    private const string pass = "9117";
    private string password;

    public GameObject inputField;
    public GameObject computerScreen;
    public GameObject key;
    public GameObject canvas;
    public GameObject ObjectiveTitle;

    public AudioSource _audioSource;
    public AudioClip _computer_startup;
    public AudioClip _computer_error;

    public Camera _playerCamera;

    public void passwordVerification()
    {
        password = inputField.GetComponent<Text>().text;
        if(password == pass)
        {
            _audioSource.PlayOneShot(_computer_startup);
            key.SetActive(true);
            computerScreen.SetActive(false);
            _playerCamera.gameObject.SetActive(true);
            canvas.gameObject.SetActive(false);

            ObjectiveTitle.GetComponent<UnityEngine.UI.Text>().text = "Objective: Find the key in the room";

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        else
        {
            _audioSource.PlayOneShot(_computer_error);
            inputField.GetComponent<Text>().text = "";
        }
    }
}
