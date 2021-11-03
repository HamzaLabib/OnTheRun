using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 3000f;
    public float sidesForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("lalalal");
        //rb.useGravity = false;
    }

    // To mess for Physics
    private void FixedUpdate()
    {
        //rb.AddForce(0, 0, 1000 * Time.deltaTime);
        GetInputs();
    }

    void GetInputs()
    {
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(sidesForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-sidesForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        if (rb.position.y < -1f)
            FindObjectOfType<GameManager>().GameOver();
    }
}
