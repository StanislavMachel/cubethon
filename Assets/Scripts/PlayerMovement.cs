using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // We marked this as "FixedUpdate" because are using it to mess with physics
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // Add a force of 2000 on the z-axis, Time.deltaTime - used that works same for each system mobile or pc with different perfomance
    }
}
