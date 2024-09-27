using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDeactivate : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;

    private void OnMouseDown()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
        canvas3.SetActive(false);
    }
}
