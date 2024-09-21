using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
