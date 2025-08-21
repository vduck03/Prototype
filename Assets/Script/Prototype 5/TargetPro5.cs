using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TargetPro5 : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xPos = 4;
    private float ySpawnPos = -6;
    private GameManagerPro5 gameManagerPro5;
    public int scoreValue;
    public ParticleSystem particle;
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomPos();
        gameManagerPro5 = GameObject.Find("GameManager").GetComponent<GameManagerPro5>();
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xPos, xPos), ySpawnPos);
    }

    private void OnMouseDown()
    {
        if (gameManagerPro5.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(particle, transform.position, particle.transform.rotation);
            gameManagerPro5.UpdateScore(scoreValue);
            if (gameObject.CompareTag("Bad"))
            {
                gameManagerPro5.GameOVer();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManagerPro5.GameOVer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
