using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [Header("Set in Inspector")]
    public AudioSource MainMenuTheme;

	// Use this for initialization
	void Start () {
	    MainMenuTheme.Play();
	}

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
