using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inspection : MonoBehaviour
{
    [SerializeField] Camera _objectCameraView;
    [SerializeField] Camera _playerCameraView;
    [SerializeField] AudioClip _paper_pickup;
    [SerializeField] AudioClip _paper_put_back;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] GameObject objectiveTitle;

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
                objectiveTitle.GetComponent<UnityEngine.UI.Text>().text = "Objective: Login to the computer";
                _audioSource.PlayOneShot(_paper_put_back);
                _playerCameraView.gameObject.SetActive(true);
                _objectCameraView.gameObject.SetActive(false);
                flag = true;
            }
        }
    }

    private void OnMouseDown()
    {
        if (flag)
        {
            _audioSource.PlayOneShot(_paper_pickup);
            _objectCameraView.gameObject.SetActive(true);
            _playerCameraView.gameObject.SetActive(false);
            flag = false;
        }
    }
}
