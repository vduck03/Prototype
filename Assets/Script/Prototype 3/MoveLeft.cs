using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerControllerPro3 playerControllerPro3;
    private float leftBound = -15f;

    private void Start()
    {
        playerControllerPro3 = GameObject.Find("Player").GetComponent<PlayerControllerPro3>();
    }

    private void Update()
    {
        if (playerControllerPro3.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
