using TMPro;
using UnityEngine;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreLabel;

    private void Update()
    {
        _scoreLabel.text = ScoreManager.Instance.Score;
    }
}
