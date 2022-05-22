using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min;
    [SerializeField] private int _max;

    [SerializeField] private TextMeshProUGUI InfoLabel;
    [SerializeField] private TextMeshProUGUI GuessLable;
    [SerializeField] private Button MoreButton;
    [SerializeField] private Button SmallerButton;
    [SerializeField] private Button RightButton;

    private int _guess;

    private void Start()
    {
        SetInfoText($"загадай число от {_min} до {_max}");
        CalculateGuess();
        MoreButton.onClick.AddListener(MoreBottonClicked);
        SmallerButton.onClick.AddListener(SmallerBottonClicked);
        RightButton.onClick.AddListener(RightBottonClicked);
    }

    private void Update()
    {
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
        SetInfoGuessText($"твоё число: {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }
    
    private void SetInfoGuessText(string text)
    {
        Debug.Log(text);
        GuessLable.text = text;
    }

    private void MoreBottonClicked ()
    {
        SetInfoText("число больше");
        _min = _guess;
        CalculateGuess();
    }
    private void RightBottonClicked ()
    {
        SetInfoText($"ПОБЕДА !!!! твоё число {_guess}"); 
    }
    private void SmallerBottonClicked ()
    {
        SetInfoText("число меньше");
        _max = _guess;
        CalculateGuess();
    }
    
}