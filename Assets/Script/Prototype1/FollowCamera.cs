using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset = new Vector3(0, 9, -15);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
