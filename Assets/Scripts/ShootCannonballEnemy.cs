using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannonballEnemy : MonoBehaviour
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
        
    }
}
