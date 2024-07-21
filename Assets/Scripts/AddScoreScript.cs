using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreScript : MonoBehaviour
{
    public static TMP_Text scoreElement;
    public NewButtonScript script;
    void Start()
    {
        script = GameObject.Find("GenerateButton").GetComponent<NewButtonScript>();
        scoreElement = gameObject.GetComponent<TMP_Text>();
        scoreElement.text = "0";
        script.NewButton();
    }

    public void AddScore()
    {
        int score = int.Parse(scoreElement.text) + 1;
        scoreElement.text = score.ToString();
        script.buttons[NewButtonScript.newButtonIndex].GetComponent<Image>().color = Color.white;
        script.NewButton();
    }
}
