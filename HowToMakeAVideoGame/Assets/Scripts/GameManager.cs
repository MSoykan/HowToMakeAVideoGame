using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    // Start is called before the first frame update
    public bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    private void Awake() {
        instance = this;
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won");

    }

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            //Restart Game 
            Restart();
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
