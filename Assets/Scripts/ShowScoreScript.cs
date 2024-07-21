using UnityEngine;
using TMPro;

public class ShowScoreScriptt : MonoBehaviour
{
    TMP_Text score;
    void Start()
    {
        score = gameObject.GetComponent<TMP_Text>();
        score.text = "Your score was " + ScoreTransferScript.score + ".";

    }
}