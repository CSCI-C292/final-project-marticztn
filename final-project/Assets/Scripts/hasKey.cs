using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasKey : MonoBehaviour
{
    public GameObject levelCompletedCanvas;
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnCollisionEnter(Collision other)
    {
        if(GameObject.Find("KEY_PASS"))
        {
            GameObject.Find("bg_ambience").SetActive(false);
            audioSource.PlayOneShot(audioClip);
            levelCompletedCanvas.gameObject.SetActive(true);
        }
    }
}
