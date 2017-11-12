using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter() //the trigger that ends the level
    {
        gameManager.CompleteLevel();
    }
}