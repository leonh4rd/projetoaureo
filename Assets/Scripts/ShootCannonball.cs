using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannonball : MonoBehaviour
{
    [SerializeField]
    Transform cannonballPrefab;
    [SerializeField]
    float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Transform cannonball = Instantiate(cannonballPrefab, transform.position, Quaternion.identity);
            Vector2 velocity = transform.right * speed;
            cannonball.GetComponent<Rigidbody2D>().AddForce(velocity, ForceMode2D.Impulse);
        }
    }
}
