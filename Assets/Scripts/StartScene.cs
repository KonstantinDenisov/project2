using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _startSceneLabel;
    [SerializeField] private Image _locationImage;
    void Start()
    {
        SetInfoText("тебя приветствует игра Magic Numbers !");
    }

  
    private void SetInfoText(string text)
    {
        Debug.Log(text);
        _startSceneLabel.text = text;
    }
}
