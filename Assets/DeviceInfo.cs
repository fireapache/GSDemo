using UnityEngine;
using System.Collections.Generic;

public class DeviceInfo : MonoBehaviour
{
    private List<string> data;

	void Start()
    {
        data = new List<string>();

        data.Add(SystemInfo.deviceUniqueIdentifier);// VARCHAR(64)
        data.Add(SystemInfo.deviceModel);           // VARCHAR(64)
        data.Add(SystemInfo.deviceName);            // VARCHAR(16)
        data.Add(SystemInfo.deviceType.ToString()); // VARCHAR(16)
        data.Add(Application.platform.ToString());  // VARCHAR(16)


    }
	
    void OnGUI()
    {
        for (int i = 0; i < data.Count; i++)
        {
            GUI.Label(new Rect(0, i * 20, 500, 500), data[i] + " (" + data[i].Length + ")");
        }
        
    }

}
