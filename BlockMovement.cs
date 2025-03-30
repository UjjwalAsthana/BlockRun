using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce= 2000f;
    public float LeftRight= 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(LeftRight*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-LeftRight*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
