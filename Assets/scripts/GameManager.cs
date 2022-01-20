using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float delay=3f;
    public Transform playercontrolsprob;
    bool OverAldready=false;
    public GameObject levelcomppan;
    public void LevelComplete()
    {
        levelcomppan.SetActive(true);
    }
    public void EndGame()
    {
        if (OverAldready == false)
        {
            OverAldready = true;
            Invoke("Restart", delay);
        }
        
    }
    void Update()
    {
        if(playercontrolsprob.position.y <= 0)
        {
            EndGame();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}