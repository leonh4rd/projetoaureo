using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDirection : MonoBehaviour
{
    [SerializeField]
    private Transform mouthHole;

    public Transform GetPositionAndOrientation()
    {
        return mouthHole;
    }
}
