using UnityEngine;

public class FlyForward : MonoBehaviour
{
    public float speed = 40.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
