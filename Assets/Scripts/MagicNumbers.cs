using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    
    private int _stepValue = 0;

    private void Start()
    {
        SetInfoText($"загадай число от {_min} до {_max}");
        CalculateGuess();
        MoreButton.onClick.AddListener(MoreBottonClicked);
        SmallerButton.onClick.AddListener(SmallerBottonClicked);
        RightButton.onClick.AddListener(RightBottonClicked);
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
        _stepValue++;
        SetInfoText($"число больше. количество шагов {_stepValue}");
        _min = _guess;
        CalculateGuess();
    }
    private void RightBottonClicked ()
    {
        ScoreManager.Instance.Score = $"ПОБЕДА !!!! твоё число {_guess}. количество шагов {_stepValue}";
        //SetInfoText($"ПОБЕДА !!!! твоё число {_guess}. количество шагов {_stepValue}");
        //_min = 0;
        //_max = 0;
        //_guess = 0;
        //SetInfoGuessText(string.Empty);
        SceneManager.LoadScene(2);

    }
    private void SmallerBottonClicked ()
    {
        _stepValue++;
        SetInfoText($"число меньше. количество шагов {_stepValue}");
        _max = _guess;
        CalculateGuess();
    }
    
}