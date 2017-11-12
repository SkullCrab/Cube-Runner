using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public void OnCollisionEnter(Collision collisionInfo)
    {
          if (collisionInfo.collider.tag == "Obstacle") //if player hits obsticle then player stops moving and restarts
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            
        }
    }

}
