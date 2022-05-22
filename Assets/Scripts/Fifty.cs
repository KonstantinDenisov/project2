using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Fifty : MonoBehaviour
{
    [SerializeField] private Button Num1;
    [SerializeField] private Button Num2;
    [SerializeField] private Button Num3;
    [SerializeField] private Button Num4;
    [SerializeField] private Button Num5;
    [SerializeField] private Button Num6;
    [SerializeField] private Button Num7;
    [SerializeField] private Button Num8;
    [SerializeField] private Button Num9;
    [SerializeField] private Button Space;

    [SerializeField] private TextMeshProUGUI InfoLabel;
    [SerializeField] private TextMeshProUGUI ResultLabel;
    [SerializeField] private TextMeshProUGUI StepValueLable;

    private int _summ = 0;
    private int _stepValue = 0;
    
    
    void Start()
    {
        Num1.onClick.AddListener(Num1Clikest);
        Num2.onClick.AddListener(Num2Clikest);
        Num3.onClick.AddListener(Num3Clikest);
        Num4.onClick.AddListener(Num4Clikest);
        Num5.onClick.AddListener(Num5Clikest);
        Num6.onClick.AddListener(Num6Clikest);
        Num7.onClick.AddListener(Num7Clikest);
        Num8.onClick.AddListener(Num8Clikest);
        Num9.onClick.AddListener(Num9Clikest);
        
        SetInfoText("наберите сумму 50");

        Space.onClick.AddListener(SpaceClike);

    }

    private void SpaceClike()
    {
        _summ = 0;
        _stepValue = 0;
        ResultLabelText(" ");
        StepValueLableText(" ");
    }

    void Update()
    {
        
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }

    private void ResultLabelText(string text)
    {
        Debug.Log(text);
        ResultLabel.text = text;
    }

    private void StepValueLableText(string text)
    {
        Debug.Log(text);
        StepValueLable.text = text;
    }
    
    private void Num9Clikest()
    {
        _summ += 9;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num8Clikest()
    {
        _summ += 8;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num7Clikest()
    {
        _summ += 7;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num6Clikest()
    {
        _summ += 6;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num5Clikest()
    {
        _summ += 5;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num4Clikest()
    {
        _summ += 4;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num3Clikest()
    {
        _summ += 3;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num2Clikest()
    {
        _summ += 2;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }

    private void Num1Clikest()
    {
        _summ += 1;
        _stepValue++;
        ResultLabelText($"{_summ}");
        if (_summ >= 50)
        {
            SetInfoText("конец игры");
            StepValueLableText($"количество шагов - {_stepValue}");
        }
    }
}
