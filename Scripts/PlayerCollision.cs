
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
        }
       // Debug.Log(collisionInfo.collider.tag);
    }
}
