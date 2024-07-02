
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        float finalScore = PlayerPrefs.GetFloat("PlayerScore", 0); // Default to 0 if not found
        scoreText.text = finalScore.ToString("F0"); // Format to show no decimal places
    }
}