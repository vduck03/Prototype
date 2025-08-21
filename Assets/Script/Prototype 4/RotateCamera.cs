using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotateSpeed * Time.deltaTime);
    }
}
