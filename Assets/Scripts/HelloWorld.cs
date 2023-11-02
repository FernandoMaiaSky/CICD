using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    void Start()
    {
        text.text = "Hello World";
        Debug.Log("Hello World!!! What a beautiful day");
    }
}