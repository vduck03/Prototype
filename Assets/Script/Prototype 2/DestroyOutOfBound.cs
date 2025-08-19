using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
