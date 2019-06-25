
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    

    void OnCollisionEnter( Collision collisionInfo)
      {

        if(collisionInfo.collider.tag == "Obstacle")
        {
        // Ao bater em obstáculo, cessa movimento
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
       // Debug.Log(collisionInfo.collider.tag);
    }
}
