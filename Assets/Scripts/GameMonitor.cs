using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMonitor : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDealay = 2f;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDealay);
        }
      
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
