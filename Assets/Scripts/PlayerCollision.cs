using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit obstacle");
            playerMovement.enabled = false; //Make player stop moving when collision happens
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
