using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI skor_tx; // Use TextMeshProUGUI for TextMeshPro
    public static float skor;

    void Start()
    {
        skor = 0;
    }

    void Update()
    {
        if (skor_tx != null)
        {
            skor_tx.text = skor.ToString("F0"); // Format to show no decimal places
        }
        else
        {
            Debug.LogError("skor_tx is not assigned in the Inspector");
        }
    }

    public static void SaveScore()
    {
        PlayerPrefs.SetFloat("PlayerScore", skor);
    }
}