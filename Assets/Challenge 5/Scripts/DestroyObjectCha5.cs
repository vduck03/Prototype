using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectCha5 : MonoBehaviour
{
    private float multiplier;
    void Start()
    {
        Destroy(gameObject, 2.0f / multiplier); // destroy particle after 2 seconds
        Debug.Log(multiplier);
    }

    public float Difficulty(float _multiplier)
    {
        return multiplier = _multiplier;
    }

}
