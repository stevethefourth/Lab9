using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private static float speedModifier = 1.0f;
    public enum GameSpeed { Slow = 1, Fast = 3 };
    private static GameSpeed currentSpeedState = GameSpeed.Slow;
    public static GameSpeed CurrentSpeedState
    {
        get
        {
            return currentSpeedState;
        }
        set
        {
            currentSpeedState = value; 
            speedModifier = (float)currentSpeedState;


        }
    }
    public static float SpeedModifier
    {
        get
        {
            return speedModifier;
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
