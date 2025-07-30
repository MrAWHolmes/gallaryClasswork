using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public GameObject Object;   // Object to rotate

    public float rotationSpeed; // Speed of rotation  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Update the target rotation with the new Y-axis value
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
