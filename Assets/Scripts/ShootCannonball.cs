using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannonball : MonoBehaviour
{
    [SerializeField]
    private Transform cannonballPrefab = null;
    [SerializeField]
    private float speed = 1f;

    private Transform hole;

    private void Awake() 
    {
        hole = GetComponent<ShootDirection>().GetPositionAndOrientation();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Transform cannonball = Instantiate(cannonballPrefab, hole.position, Quaternion.identity);
            Vector2 velocity = hole.right * speed;
            cannonball.GetComponent<Rigidbody2D>().AddForce(velocity, ForceMode2D.Impulse);
        }
    }
}
