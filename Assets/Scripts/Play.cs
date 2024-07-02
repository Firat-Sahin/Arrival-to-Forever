using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame function called");
        SceneManager.LoadScene("GameScene");
    }
}