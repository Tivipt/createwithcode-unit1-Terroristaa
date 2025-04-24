using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        Private float speed = 5.0f;
        Private float turnSpeed = 25.0f; 
        Private float horizontalInput;
        Private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);

        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
