using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public void StartGame()
{public Animator startButton;
public Animator settingsButton;
public void OpenSettings()
{
    startButton.SetBool("isHidden", true);
    settingsButton.SetBool("isHidden", true);
}
SceneManager.LoadScene("RocketMouse");
}
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void
    {
        
    }

    // Update is called once per frame
    void
    {
        
    }
}
