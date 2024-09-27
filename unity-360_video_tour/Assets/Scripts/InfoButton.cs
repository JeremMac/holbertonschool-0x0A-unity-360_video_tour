using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Composites;

public class InfoButton : MonoBehaviour
{
    public GameObject textBox;
    public GameObject button;
    private void OnMouseDown()
    {
        if (textBox.activeSelf)
        {
            textBox.SetActive(false);
        }
        else
        {
            textBox.SetActive(true);
        }
    }
    public void OnMouseEnter()
    {
        button.transform.localScale = new Vector3(1.5f, 1.5f ,1.5f);
    }
    public void OnMouseExit()
    {
        button.transform.localScale = new Vector3(1, 1, 1);
    }
}
