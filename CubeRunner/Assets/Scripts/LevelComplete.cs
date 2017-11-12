using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        //Gets next build index number and starts that level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
}
