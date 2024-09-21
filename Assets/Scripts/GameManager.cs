using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; // assign panel in inspector
    public GameObject victoryPanel; 
    
    void Start()
    {
        // hide panel at game start
        gameOverPanel.SetActive(false);
        victoryPanel.SetActive(false);
    }

    public void GameOver()
    {
        // show panel 
        gameOverPanel.SetActive(true);
    }
    public void Victory()
    {
        victoryPanel.SetActive(true);
    }
    public void RestartGame()
    {
        // reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        // if running in the editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running as a standalone build
        Application.Quit();
#endif
    }


}
