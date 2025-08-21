using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody rbEnemy;
    private GameObject player;
    private float deathPos = -10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        rbEnemy.AddForce(direction * speed);
        if (transform.position.y < deathPos)
        {
            Destroy(gameObject);
        }
    }
}
