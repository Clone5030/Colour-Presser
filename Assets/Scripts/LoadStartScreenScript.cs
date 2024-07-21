using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadStartScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        SceneManager.LoadScene("PlayScreen");
    }
}
