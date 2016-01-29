using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System.Collections;
using GameSparks.Api.Requests;
using GameSparks.Core;
using GameSparks.Platforms;
using GameSparks.Platforms.IOS;

public class GSDemoManager : Singleton<GSDemoManager>
{
    static IGSPlatform dP;

    static GameObject logObject;
    static GameObject functionsPanel;
    static GameObject loginPanel;
    static GameObject registerPanel;

    static Text logComponent;
    static InputField registerUsername;
    static InputField registerPassword;
    static InputField registerEmail;
    static InputField loginUsername;
    static InputField loginPassword;

    protected GSDemoManager() { }
    
    void Start()
    {
        Init();
    }

    static void Init()
    {
        logObject = GameObject.FindGameObjectWithTag("LogWindow");
        logComponent = logObject.GetComponent<Text>();

        registerUsername = GameObject.FindGameObjectWithTag("RegisterUsername").GetComponent<InputField>();
        registerPassword = GameObject.FindGameObjectWithTag("RegisterPassword").GetComponent<InputField>();
        registerEmail = GameObject.FindGameObjectWithTag("RegisterEmail").GetComponent<InputField>();

        loginUsername = GameObject.FindGameObjectWithTag("LoginUsername").GetComponent<InputField>();
        loginPassword = GameObject.FindGameObjectWithTag("LoginPassword").GetComponent<InputField>();

        functionsPanel = GameObject.FindGameObjectWithTag("Functions");
        loginPanel = GameObject.FindGameObjectWithTag("Login");
        registerPanel = GameObject.FindGameObjectWithTag("Register");

        functionsPanel.SetActive(true);
        loginPanel.SetActive(false);
        registerPanel.SetActive(false);
    }

    static public void GoToLoginPanel()
    {
        if (!Connected()) return;

        functionsPanel.SetActive(false);
        loginPanel.SetActive(true);
        registerPanel.SetActive(false);
    }

    static public void GoToFunctionsPanel()
    {
        functionsPanel.SetActive(true);
        loginPanel.SetActive(false);
        registerPanel.SetActive(false);
    }

    static public void GoToRegisterPanel()
    {
        if (!Connected()) return;

        functionsPanel.SetActive(false);
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);
    }

    static public void Connect()
    {
        if (GS.Available)
        {
            AddLog("Already connected!");
            return;
        }

        ResetLog();
        AddLog("Connecting to GameSparks...");

        GS.GameSparksAvailable = (available) =>
        {
            if (available)
            {
                AddLog("GameSparks Available!");

                new DeviceAuthenticationRequest().Send((response) =>
                {
                    AddLog("Authenticating device...");

                    if (!response.HasErrors)
                    {
                        AddLog("Device Authenticated!");
                    }
                    else
                    {
                        AddLog(response.Errors.ToString());
                    }
                });
            }
            else
            {
                AddLog("Failed to connect!");
            }
        };

#if UNITY_IOS && !UNITY_EDITOR
        dP = GameObject.FindGameObjectWithTag("GSDemoManager").AddComponent<IOSPlatform>();
		GS.Initialise(dP);
#else
        dP = GameObject.FindGameObjectWithTag("GSDemoManager").AddComponent<DefaultPlatform>();
        GS.Initialise(dP);
#endif

    }

    static public bool Connected()
    {
        if (!GS.Available)
        {
            AddLog("Need connection!");

            return false;
        }
        else return true;
    }

    static void ResetLog()
    {
        logComponent.text = "";
    }

    static void AddLog(string message)
    {
        logComponent.text = message + "\n\n" + logComponent.text;
    }

    static void EmailValidation()
    {
        new LogEventRequest_EmailValidation()
        .Set_Email(registerEmail.text)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.JSON);
                AddLog("E-mail already exists!");
                return;
            }
            else CheckUsername();
        });
    }

    static void CheckUsername()
    {
        new LogEventRequest_UsernameCheck()
        .Set_Username(registerUsername.text)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.JSON);
                AddLog("Username invalid...");
                return;
            }
            else RegisterUser();
        });
    }

    static void RegisterUser()
    {
        new RegistrationRequest()
        .SetUserName(registerUsername.text)
        .SetPassword(registerPassword.text)
        .SetDisplayName(registerUsername.text)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.JSON);
                AddLog("Something went wrong...");
            }
            else
            {
                AddLog("User successfully created!");
                RegisterPersonalProfile();
            }
        });
    }

    static void RegisterPersonalProfile()
    {
        new LogEventRequest_CreatePP()
        .Set_Email(registerEmail.text)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.JSON);
                AddLog("Problems trying to create user's Personal Profile...");
            }
            else
            {
                AddLog("User's Personal Profile created!");
                RegisterDevice();
            }
        });
    }

    static string GetDeviceTypeString(DeviceType type)
    {
        string result = "";

        switch(type)
        {
            case DeviceType.Handheld:
                result = "Handheld";
                break;
            case DeviceType.Desktop:
                result = "Desktop";
                break;
            case DeviceType.Console:
                result = "Console";
                break;
            case DeviceType.Unknown:
                result = "Unknow";
                break;
        }

        return result;
    }

    static string GetGraphicsDeviceTypeString(GraphicsDeviceType type)
    {
        string result = "";

        switch (type)
        {
            case GraphicsDeviceType.OpenGLES2:
                result = "OpenGLES2";
                break;
            case GraphicsDeviceType.OpenGLES3:
                result = "OpenGLES3";
                break;
            case GraphicsDeviceType.Metal:
                result = "Metal";
                break;
            case GraphicsDeviceType.OpenGL2:
                result = "OpenGL2";
                break;
            case GraphicsDeviceType.OpenGLCore:
                result = "OpenGLCore";
                break;
            case GraphicsDeviceType.Direct3D9:
                result = "Direct3D9";
                break;
            case GraphicsDeviceType.Direct3D11:
                result = "Direct3D11";
                break;
            case GraphicsDeviceType.Direct3D12:
                result = "Direct3D12";
                break;
            case GraphicsDeviceType.XboxOne:
                result = "XboxOne";
                break;
            case GraphicsDeviceType.Xbox360:
                result = "Xbox360";
                break;
            case GraphicsDeviceType.PlayStation3:
                result = "PlayStation3";
                break;
            case GraphicsDeviceType.PlayStation4:
                result = "PlayStation4";
                break;
            default:
                result = "Null";
                break;


        }

        return result;
    }

    static void RegisterDevice()
    {
        string id = SystemInfo.deviceUniqueIdentifier;
        string model = SystemInfo.deviceModel;
        string name = SystemInfo.deviceName;
        string type = GetDeviceTypeString(SystemInfo.deviceType);
        string platform = SystemInfo.operatingSystem;
        string processor = SystemInfo.processorType;
        string graphics = GetGraphicsDeviceTypeString(SystemInfo.graphicsDeviceType);

        new LogEventRequest_RegisterDevice()
        .Set_ID(id)
        .Set_Model(model)
        .Set_Name(name)
        .Set_Type(type)
        .Set_Platform(platform)
        .Set_Processor(processor)
        .Set_Graphics(graphics)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.GetString("ERROR"));
                AddLog("Problems registering device...");
            }
            else
            {
                AddLog("Device registered!");
            }
        });
    }

    static public void CreateUser()
    {
        if (!Connected()) return;

        AddLog("Creating user...");

        EmailValidation();
    }

    static public void LoginUser()
    {
        new AuthenticationRequest()
        .SetUserName(loginUsername.text)
        .SetPassword(loginPassword.text)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.GetString("DETAILS"));
                AddLog("Could not login:");
            }
            else
            {
                AddLog("User logged in!");
                LoginDevice();
            }
        });
    }

    static public void LoginDevice()
    {
        new LogEventRequest_LoginDevice()
        .Set_ID(SystemInfo.deviceUniqueIdentifier)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.GetString("MSG"));
                AddLog("Could not login the device:");
                AddLog("Registering device...");
                RegisterDevice();
            }
            else
            {
                AddLog("Device accepted!");
            }
        });
    }

    static public void ShowDeviceSpecs()
    {
        if (!Connected()) return;

        new LogEventRequest_GetDeviceSpecs()
        .Set_ID(SystemInfo.deviceUniqueIdentifier)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.GetString("MSG"));
            }
            else
            {
                GSData data = response.ScriptData.GetGSData("Data");
                string message = "";

                message += "ID:\t" + data.GetString("ID") + '\n';
                message += "User:\t" + data.GetString("User") + '\n';
                message += "Model:\t" + data.GetString("Model") + '\n';
                message += "Name:\t" + data.GetString("Name") + '\n';
                message += "Type:\t" + data.GetString("Type") + '\n';
                message += "Platform:\t" + data.GetString("Platform") + '\n';
                message += "Processor:\t" + data.GetString("Processor") + '\n';
                message += "Graphics:\t" + data.GetString("Graphics");

                AddLog(message);
            }
        });
    }

    static public void ShowPersonalProfile()
    {
        if (!Connected()) return;

        new LogEventRequest_GetPersonalProfile()
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                AddLog(response.Errors.GetString("MSG"));
            }
            else
            {
                GSData data = response.ScriptData.GetGSData("Data");
                string message = "";

                message += "User:\t" + data.GetString("User") + '\n';
                message += "FirstName:\t" + data.GetString("FirstName") + '\n';
                message += "LastName:\t" + data.GetString("LastName") + '\n';
                message += "Email:\t" + data.GetString("Email") + '\n';
                message += "Device1:\t" + data.GetString("Device1") + '\n';
                message += "Device2:\t" + data.GetString("Device2") + '\n';
                message += "Device3:\t" + data.GetString("Device3") + '\n';
                message += "ModuleA:\t" + data.GetString("ModuleA") + '\n';
                message += "ModuleB:\t" + data.GetString("ModuleB");

                AddLog(message);

            }
        });
    }
    
}
