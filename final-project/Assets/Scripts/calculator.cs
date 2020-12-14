using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculator : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Entered!");
        transform.Find("CalculatorLight").gameObject.SetActive(true);

    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit!");
        transform.Find("CalculatorLight").gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse down!");
    }
}
