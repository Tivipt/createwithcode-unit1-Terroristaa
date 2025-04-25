using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float rotationSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its forward axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
