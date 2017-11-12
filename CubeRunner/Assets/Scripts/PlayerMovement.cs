using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 2000f;

    // Update is called once per frame
    void FixedUpdate () { 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Constantly pushing player forward

        if (Input.GetKey("d"))
        {
            //moving right if "d" is pressed
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //moving left if "a" is pressed
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        */
        if (rb.position.y < -1f)
        {
            //Starting over if player falls off ground
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
