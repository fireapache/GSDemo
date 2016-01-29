using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GameSparks.Api.Requests;
using GameSparks.Core;
using GameSparks.Platforms;

public class GSDemoScript : MonoBehaviour
{
    bool Connected()
    {
        return GSDemoManager.Connected();
    }

	public void Connect()
    {
        GSDemoManager.Connect();
    }

    public void GoToLoginPanel()
    {
        GSDemoManager.GoToLoginPanel();
    }

    public void GoToFunctionsPanel()
    {
        GSDemoManager.GoToFunctionsPanel();
    }

    public void GoToRegisterPanel()
    {
        GSDemoManager.GoToRegisterPanel();
    }

    public void CreateUser()
    {
        GSDemoManager.CreateUser();
    }

    public void LoginUser()
    {
        GSDemoManager.LoginUser();
    }

    public void ShowDeviceSpecs()
    {
        GSDemoManager.ShowDeviceSpecs();
    }

    public void ShowPersonalProfile()
    {
        GSDemoManager.ShowPersonalProfile();
    }

}
