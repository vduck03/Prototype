using UnityEngine;

public class SpinNinjaGo : MonoBehaviour
{
    public float speedRotate = 100;
    void Update()
    {
        transform.Rotate(Vector3.forward, speedRotate * Time.deltaTime);
    }
}
