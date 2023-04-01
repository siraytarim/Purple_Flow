using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool gameHasEnd = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        
    }

    public void EndGame()
    {
        if (gameHasEnd == false)
        {
            gameHasEnd = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);

        }
        
    }

     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
