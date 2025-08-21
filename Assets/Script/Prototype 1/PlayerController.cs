using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 45f;
    private float HorizontalInput;
    private float forwardInput;
    
    void Update()
    {
        //Player Input
        HorizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //Move car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move car rotate
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
