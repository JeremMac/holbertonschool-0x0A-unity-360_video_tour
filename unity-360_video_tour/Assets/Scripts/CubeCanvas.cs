using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCanvas : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;

    private void OnMouseDown()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(true);
        canvas3.SetActive(true);
    }
}
