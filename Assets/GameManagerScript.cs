using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    private SoundController soundController;

    private void Start()
    {
        gameOverPanel.SetActive(false); // Hide panel initially
        soundController = FindObjectOfType<SoundController>(); // Find SoundController in scene
    }

    public void GameOver()
    {
        Time.timeScale = 0f; // Pause the game
        gameOverPanel.SetActive(true);

        if (soundController != null)
        {
            soundController.StopAllSounds(); // Stop sounds
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Reset time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
