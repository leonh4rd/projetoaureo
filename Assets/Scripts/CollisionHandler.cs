using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        //if(!other.gameObject.tag.Equals("Player"))
        //{
            Destroy(gameObject);
        //}
    }
}
