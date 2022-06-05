using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public string Score;

    private static ScoreManager _instance;
    private static int _number;

    public static ScoreManager Instance => _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    
}
