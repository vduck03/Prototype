using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timerMax = 2.0f;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) &&  timer >= timerMax)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0.0f;
        }
    }
}
