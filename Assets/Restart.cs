using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Method to restart GameScene
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene"); // Load GameScene
    }
}