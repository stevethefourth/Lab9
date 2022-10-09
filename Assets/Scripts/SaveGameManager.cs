using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    void Awake()
    {
        SetSpeedPref();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveSpeed()
    {
        PlayerPrefs.SetInt("SpeedSave", (int)SpeedManager.CurrentSpeedState);
        PlayerPrefs.Save();
    }

    public void SetSpeedPref()
    {
        var speeddd = PlayerPrefs.GetInt("SpeedSave") == 1 ? SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Slow : 
                                                                 SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Fast;
    }
}
