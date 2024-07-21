using UnityEngine;

public class ScoreTransferScript : MonoBehaviour
{
    public static string score;
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public void SaveScore()
    {
        score = AddScoreScript.scoreElement.text;
    }
}
