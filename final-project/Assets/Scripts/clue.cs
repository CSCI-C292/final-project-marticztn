using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clue : MonoBehaviour
{
    [SerializeField] Camera _cam;
    [SerializeField] Light _light;
    [SerializeField] GameObject ItemName;
    bool isOnFocus = false;

    private void OnMouseEnter()
    {
        ItemName.SetActive(true);
        ItemName.GetComponent<UnityEngine.UI.Text>().text = (name == "A weird note" ? "A weird note, maybe this is the computer login password?" : "Computer Screen, I have to know the password...");
        _light.gameObject.SetActive(true);

    }

    private void OnMouseExit()
    {
        ItemName.SetActive(false);
        _light.gameObject.SetActive(false);
    }
}
