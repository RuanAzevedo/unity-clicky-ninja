using UnityEngine;
using UnityEngine.UI;

public class DificultyButton : MonoBehaviour
{
    [SerializeField] private int difficulty;

    private Button button;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
