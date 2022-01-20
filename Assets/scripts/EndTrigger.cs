using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public score scoreinthis;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag != "ObstaclesInGame")
        {
            gameManager.LevelComplete();
            scoreinthis.finalscoretext.text = SceneManager.GetActiveScene().name.ToString();
        }
        
    }

}
