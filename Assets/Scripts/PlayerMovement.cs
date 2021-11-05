using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public GameObject[] tiles;

    public float forwardForce;
    public float upwardForce;
    public float sidewaysForce;
  
    void Start()
    {
        //Update ham sort sau
        //tiles = GameObject.FindGameObjectsWithTag("Tile");


        //for (int i = 0; i < tiles.Length; i++)
        //    Debug.Log(tiles[i].transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Condition to restart the level
        //if (rb.position.y < 0f)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "Obstacle")
        //{
        //    Debug.Log("We hit obstacle");
        //    playerMovement.enabled = false; //Make player stop moving when collision happens
        //    FindObjectOfType<GameManager>().EndGame();
        //}
        Debug.Log("COLLISION!");
        rigidBody.velocity = Vector3.zero;
        rigidBody.AddForce(0, forwardForce, upwardForce, ForceMode.VelocityChange);
        Debug.Log(rigidBody.position);
    }
}
