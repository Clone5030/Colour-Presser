using UnityEngine;
using UnityEngine.UI;

public class NewButtonScript : MonoBehaviour
{
    public GameObject[] buttons;
    [HideInInspector]
    public static GameObject newButton;
    public static int newButtonIndex;
    System.Random rand = new();
    public void NewButton()
    {
        newButtonIndex = rand.Next(0, buttons.Length);
        newButton = buttons[newButtonIndex];
        newButton.GetComponent<Image>().color = Color.red;
    }
}

