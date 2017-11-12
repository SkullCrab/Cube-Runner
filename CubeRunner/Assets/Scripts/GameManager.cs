using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void CompleteLevel() //Shows Level Complete
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if (gameHasEnded == false) //Game has ended
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    void Restart() //Restarts level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
   
}	