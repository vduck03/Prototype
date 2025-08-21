using System;
using System.Collections;
using UnityEngine;

public class PlayerControllerPro4 : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10f;
    private GameObject focalPoint;
    public bool isPowerUp;
    private float powerUpStrength = 15f;
    public GameObject powerUpRing;

    private void Start()
    {
        rb =  GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        powerUpRing.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            isPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdownRoutine());
            powerUpRing.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enemy") && isPowerUp)
        {
            Rigidbody rbEnemy = other.gameObject.GetComponent<Rigidbody>();
            Vector3 pushAway = (other.gameObject.transform.position - transform.position);
            Debug.Log("oke roi nha");
            rbEnemy.AddForce(pushAway * powerUpStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7f);
        isPowerUp = false;
        powerUpRing.gameObject.SetActive(false);
    }
}
