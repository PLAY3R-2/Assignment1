using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    void Start()
    {

    }
    private void StartGame()
    {
        isGameOver = false;
        blue.isSolved = false;
        green.isSolved = false;
        red.isSolved = false;
        orange.isSolved = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("JHelewa_Hour10");
    }
    // Update is called once per frame
    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    
    void OnGUI()
        {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2, 240, 30);
                if (GUI.Button(startButton, "Click or Press Enter to Play Again") || Input.GetKeyDown(KeyCode.Return))
                {
                    StartGame();
                }
            }
        }
    }
