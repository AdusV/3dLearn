
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFuncionality : MonoBehaviour
{
    public GameObject panelMenu;
    public bool isMenuButton;
    public void TurnOnMenu()
    {
        if (isMenuButton)
        {
            panelMenu.SetActive(false);
            isMenuButton = false    ;
        }
        else
        {
            panelMenu.SetActive(true);
            isMenuButton = true;
        }
    }
}
