using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float rotationSpeed = 4000f; // Speed of propeller rotation
    public GameObject propeller; // Reference to the propeller GameObject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); // Rotate the propeller around the Y-axis
    }
}
