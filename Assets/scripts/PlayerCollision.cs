using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public playerMovement playermovement;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "ObstaclesInGame")
        {
            playermovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
