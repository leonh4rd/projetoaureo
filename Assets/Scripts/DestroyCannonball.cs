using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCannonball : MonoBehaviour
{
    private float seconds;
    private float counter;

    void Start()
    {
        seconds = 5f;
        counter = 0f;
    }

    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= seconds)
        {
            Destroy(gameObject);
        }
    }
}
