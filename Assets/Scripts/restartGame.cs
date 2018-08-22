using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {

	// Use this for initialization

    public void RestartGame()
    {
        SceneManager.LoadScene("Actual-Main"); // loads current scene
    }

}

