using UnityEngine;

public class PlayerControllerPro2 : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 40.0f;
    private float limitDistance = 15.0f;
    public GameObject foodPrefab;
    void Update()
    {
        if (transform.position.x < -limitDistance)
        {
            transform.position = new Vector3(-limitDistance, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitDistance)
        {
            transform.position = new Vector3(limitDistance, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
