using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.isEditor) { 
        } else {
            //Turns off stack trace for Debug.Log to cut down on log noise
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
    }

    private void OnGUI()
    {
        NetworkHelper.GUILayoutNetworkControls();
    }
}
