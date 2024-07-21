using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        Application.Quit();
    }
}
