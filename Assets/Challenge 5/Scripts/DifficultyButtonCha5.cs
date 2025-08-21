using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonCha5 : MonoBehaviour
{
    private Button button;
    private GameManagerCha5 _gameManagerCha5;
    private int difficulty;
    private DestroyObjectCha5 _destroyObjectCha5;

    // Start is called before the first frame update
    void Start()
    {
        _gameManagerCha5 = GameObject.Find("Game Manager").GetComponent<GameManagerCha5>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        _gameManagerCha5.StartGame(difficulty);
        _destroyObjectCha5.Difficulty(difficulty);
    }
}
