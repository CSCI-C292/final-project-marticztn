using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] Light _light;
    public GameObject keyObj;
    public GameObject key_SFX;
    public GameObject ItemName;
    public GameObject ObjectiveTitle;
    bool isOnFocus = false;

    private GameObject gotKey;

    private void Start()
    {
        ItemName.SetActive(false);
    }

    private void OnMouseEnter()
    {
        _light.gameObject.SetActive(true);
        ItemName.SetActive(true);
        ItemName.GetComponent<UnityEngine.UI.Text>().text = "A key";
    }

    private void OnMouseExit()
    {
        ItemName.SetActive(false);
        _light.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        key_SFX.SetActive(true);
        ItemName.SetActive(false);
        ObjectiveTitle.GetComponent<UnityEngine.UI.Text>().text = "Objective: Open the door with your key";
        gotKey = new GameObject("KEY_PASS");

        keyObj.SetActive(false);
    }
}
