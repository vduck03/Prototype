using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject obstancle;
    private Vector3 spawnPos = new  Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControllerPro3 playerControllerPro3;
    void Start()
    {
        InvokeRepeating("SpawnManager", startDelay, repeatRate);
        playerControllerPro3 = GameObject.Find("Player").GetComponent<PlayerControllerPro3>();
    }

    // Update is called once per frame
    private void SpawnManager()
    {
        if (playerControllerPro3.gameOver == false)
        {
            Instantiate(obstancle, spawnPos, obstancle.transform.rotation);
        }
    }
}
