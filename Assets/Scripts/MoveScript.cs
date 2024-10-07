using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.AddForce(sidewayForce * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0);
        }
    }
}
