using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;

public class Clic : MonoBehaviour
{
    public GameObject Currentroom;
    
    public GameObject NextRoom;

    public GameObject clickedButtons;
    public GameObject nextRoomButton;
    public GameObject InfoButton1;
    public GameObject InfoButton2;
    public GameObject InfoButton3;
    public GameObject InfoButton4;
    public Image CurrentButton;
    public Animator fadeIn;

    public GameObject fadeCanvas;
    private void OnMouseDown()
    {
        deActivateInfos();
        Currentroom.SetActive(false);
        clickedButtons.SetActive(false);
        fadeCanvas.SetActive(false);
        fadeIn.Play("FadeIn");
        fadeCanvas.SetActive(true);

        NextRoom.SetActive(true);
        nextRoomButton.SetActive(true);
        ActivateInfos();
    }
    private void OnMouseEnter()
    {
        CurrentButton.color = Color.green;
    }
    private void OnMouseExit()
    {
        CurrentButton.color = Color.white;
    }

    public void deActivateInfos()
    {
        InfoButton1.SetActive(false);
        InfoButton2.SetActive(false);
    }
    public void ActivateInfos()
    {
        InfoButton3.SetActive(true);
        InfoButton4.SetActive(true);
    }  
}
