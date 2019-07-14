using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Cannon[] cannons;
    [SerializeField] private Transform[] location;

    private Transform[] cannonsObjects;

    void Start()
    {
        cannonsObjects = new Transform[cannons.Length];
        for(int i = 0; i < cannons.Length; i++)
        {
            cannonsObjects[i] = cannons[i].Initialize(
                location[i].position, 
                location[i].rotation, 
                location[i].localScale);
        }
    }

    void Update()
    {
        
    }
}
