using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float timer;
    private float timerMax = 2f;
    private int r;
    private int g;
    private int b;

    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
    }
    
    void Update()
    {
        Material material = Renderer.material;
        timer += Time.deltaTime;
        if(timer > timerMax){
            r = Random.Range(10, 255);
            g = Random.Range(10, 255);
            b = Random.Range(10, 255);
            timer = 0.0f;
        }
        material.color = new Color(r/255f,g/255f,b/255f,1f);
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
