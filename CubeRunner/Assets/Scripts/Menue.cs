using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour {

    public PlayerMovement movement;
    public GameObject PausedUI;

	public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Resume()
    {
        Debug.Log("Resume");
        PausedUI.SetActive(false);
        movement.enabled = true;
        Time.timeScale = 1;
    }

}
