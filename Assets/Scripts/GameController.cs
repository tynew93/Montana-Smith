using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GameMode
{
    paused,
    playing
}

public class GameController : MonoBehaviour {

    [Header("Set in Inspector")]
    public AudioSource backgroundMusic;
    public GameObject PauseMenu;
    public Text scoreText;

    private float prevTimeScale;
    private GameMode gameMode;

    void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    void Start()
    {
        PauseMenu.SetActive(false);
        gameMode = GameMode.playing;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && gameMode == GameMode.playing)
        {
            PauseGame();
        }
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            UnpauseGame();
        }
        scoreText.text = "Keys Collected: " + PlayerPrefs.GetInt("Score").ToString();
    }

    public void PauseGame()
    {
        gameMode = GameMode.paused;
        backgroundMusic.Pause();
        PauseMenu.SetActive(true);
        prevTimeScale = Time.timeScale;
        Time.timeScale = 0;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void UnpauseGame()
    {
        gameMode = GameMode.playing;
        backgroundMusic.UnPause();
        PauseMenu.SetActive(false);
        Time.timeScale = prevTimeScale;
    }
}
