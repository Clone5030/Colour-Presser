using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    Button button;
    AddScoreScript addScript;
    ScoreTransferScript scoreTransferScript;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
        addScript = FindObjectOfType<AddScoreScript>(); 
        scoreTransferScript = new();
        button.onClick.AddListener(Clicked);
    }

    public void Clicked()
    {
        if (NewButtonScript.newButton != null)
        {

            if (NewButtonScript.newButton.name == gameObject.name)
            {
                addScript.AddScore();
            }

            else
            {
                scoreTransferScript.SaveScore();
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }
}
