using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    public BlockMovement movement;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag== "Obstacle"){
            movement.enabled= false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
