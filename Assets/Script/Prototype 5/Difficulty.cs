using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button button;
    private GameManagerPro5 gameManagerPro5;
    public int difficulty;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManagerPro5 = GameObject.Find("GameManager").GetComponent<GameManagerPro5>();
    }

    public void SetDifficulty()
    {
        // if()
        gameManagerPro5.StartGame(difficulty);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
