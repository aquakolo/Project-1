using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("I hit Obstacle");
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
