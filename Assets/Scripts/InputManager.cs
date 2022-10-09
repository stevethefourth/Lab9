using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Sace = SpeedManager.CurrentSpeedState == SpeedManager.GameSpeed.Slow ? SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Fast : SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Slow;
            this.gameObject.GetComponent<SaveGameManager>().SaveSpeed();
        } 

        if (Input.GetKeyDown(KeyCode.Return) && GameManager.currentGameState != GameManager.GameState.WalkingLevel)
        {
          
            Destroy(this.gameObject.GetComponent<Tweener>());
            DontDestroyOnLoad(this.gameObject);
            GameManager.currentGameState = GameManager.GameState.WalkingLevel;
            SceneManager.LoadScene(1);

        }
    }
}
