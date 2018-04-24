using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GameMode
{
    paused,
    playing,
    won
}

public class GameController : MonoBehaviour {

    [Header("Set in Inspector")]
    public AudioSource BackgroundMusic;
    public GameObject PauseMenu;
    public GameObject WinMenu;
    public Text scoreText;
    public AudioSource WinMusic;
    public Sprite MontanaWinSprite;

    private float prevTimeScale = 0;
    private GameMode gameMode;

    void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    void Start()
    {
        PauseMenu.SetActive(false);
        WinMenu.SetActive(false);
        Time.timeScale = 1;
        gameMode = GameMode.playing;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && gameMode == GameMode.playing)
        {
            PauseGame();
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && gameMode == GameMode.paused)
        {
            UnpauseGame();
        }
        if (gameMode == GameMode.won)
        {
            GetComponent<SpriteRenderer>().sprite = MontanaWinSprite;
        }
        scoreText.text = "Keys Collected: " + PlayerPrefs.GetInt("Score").ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Idol"))
        {
            other.gameObject.SetActive(false);
            WinGame();
        }
    }

    private void WinGame()
    {
        gameMode = GameMode.won;
        prevTimeScale = Time.timeScale;
        Time.timeScale = 0;
        WinMenu.SetActive(true);
        BackgroundMusic.Stop();
        WinMusic.Play();
        
    }

    public void PauseGame()
    {
        gameMode = GameMode.paused;
        BackgroundMusic.Pause();
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
        BackgroundMusic.UnPause();
        PauseMenu.SetActive(false);
        Time.timeScale = prevTimeScale;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
