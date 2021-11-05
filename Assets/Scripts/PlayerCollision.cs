using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Rigidbody rigidBody;

    public float forwardForce = 500f;
    public float upwardForce = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "Obstacle")
        //{
        //    Debug.Log("We hit obstacle");
        //    playerMovement.enabled = false; //Make player stop moving when collision happens
        //    FindObjectOfType<GameManager>().EndGame();
        //}

        Debug.Log("COLLISION!");
        rigidBody.AddForce(0, forwardForce, upwardForce);
    }
}
