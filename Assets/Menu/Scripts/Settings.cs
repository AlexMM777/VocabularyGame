using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject SettingsScreen;
    public GameObject MenuScreen;
    public GameObject OtherScreen;
    public GameObject ExitScreen;

    public void OpenSettings()
    {
        SettingsScreen.SetActive(true);
    }
    public void OpenMenuScreen()
    {
        MenuScreen.SetActive(true);
    }
    public void OpenOth()
    {
        OtherScreen.SetActive(true);
    }
    public void OpenExit()
    {
        ExitScreen.SetActive(true);
    }



    public void CloseSettings()
    {
        SettingsScreen.SetActive(false);
    }
    public void CloseMenu()
    {
        MenuScreen.SetActive(false);
    }
    public void CloseOth()
    {
        OtherScreen.SetActive(false);
    }
    public void CloseExit()
    {
        ExitScreen.SetActive(false);
    }


}
