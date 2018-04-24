using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [Header("Set in Inspector")]
    public AudioSource MainMenuTheme;
    public GameObject MainMenuCanvas;
    public GameObject HowToPlayCanvas;

	// Use this for initialization
	void Start () {
	    MainMenuTheme.Play();
        HowToPlayCanvas.SetActive(false);
	}

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMainMenu()
    {
        HowToPlayCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
    }

    public void HowToPlay()
    {
        HowToPlayCanvas.SetActive(true);
        MainMenuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
    }
}
