using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	
	// Update is called once per frame
	void Update ()
    {
        // shows score based on where Z position is
        scoreText.text = player.position.z.ToString("0");
	}
}
