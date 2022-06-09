using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool isEnded;
    public float delayStart = 2f;
    public Text gameOver;
    public GameObject gameObjectUI;
    public void GameOver()
    {
        if(!isEnded)
        {
            isEnded = true;
            //Debug.Log("Game Over");
            //gameOver.enabled = true;
            gameOver.text = "Game Over !";
            Invoke("Restart", delayStart);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene("Level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CompleteLevel()
    {
        gameObjectUI.SetActive(true);
        Invoke("LoadNextLevel", delayStart);
    }
}
